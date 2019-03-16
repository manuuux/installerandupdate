<?php
    $config = array();
    
    $filesarray = array();
    if(isset($_POST['version']) && $_POST['version']!= ''){
        $path = './files/'.$_POST['version'].'/';
        if (!file_exists($path)) { mkdir($path, 0777, true); }
        $name       = $_FILES['file']['name'];  
        $temp_name  = $_FILES['file']['tmp_name'];  
        if(isset($name)){
            if(!empty($name)){      
                $location = $path;      
                if(move_uploaded_file($temp_name, $location.$name)){
                    $uploadOK = true;
                }
            }       
        }  else {
            echo 'You should select a file to upload !!';
        }
        if($uploadOK){
            if (file_exists($location.$name)){
                if (pathinfo($location.$name, PATHINFO_EXTENSION)=="zip"){
                    $zip = new ZipArchive;
                    if ($zip->open($location.$name) === TRUE) {
                        $zip->extractTo($location);
                        $zip->close();
                        $uploadOK = true;
                    } else {
                        $uploadOK = false;
                    }
                }
            }
        }
        if($uploadOK){
            unlink ($location.$name);
            $configoriginal = json_decode(file_get_contents('./config.json'),true);
            $config = array(
                "configuracion" => array(
                    "imagen" => $configoriginal["configuracion"]['imagen'],
                    "readme" => $configoriginal["configuracion"]['readme'],
                    "version" => $_POST['version']
                ),
                "filename" => array()
            );
            $urlarray = array();
            $filesarray = array();
            $patharray = array();
            $checksumarray = array();
            mydir($location);
            for ($i = 0; $i < sizeof($urlarray);$i++){
                $tempfilenamearray = array(
                    "archivo" => $filesarray[$i],
                    "checksum" => $checksumarray[$i],
                    "path" => $patharray[$i],
                    "url" => $urlarray[$i]
                );
                //$config["filename"] = array_merge($config["filename"], $tempfilenamearray);
                //$config["filename"] += $tempfilenamearray;
                array_push($config["filename"],$tempfilenamearray);
                $fp = fopen('config.json', 'w');
                fwrite($fp, json_encode($config));
                fclose($fp);
            }
            var_dump($config);
        }
    }else{
        echo 'No se a subido nada';
    }

    function mydir($dir){
        global $path;
        global $urlarray;
        global $filesarray;
        global $patharray;
        global $checksumarray;
        foreach(scandir($dir) as $tempfile){
            if(!is_dir($dir.$tempfile)){
                array_push($filesarray,$tempfile);
                $dirtemp = after ('./', $dir);
                $topush = $dirtemp.$tempfile;
                //$topush = urlencode($topush);
                array_push($urlarray,$topush);
                $pathtemp = after($path,$dir);
                if(!$pathtemp){$pathtemp="";}
                array_push($patharray,$pathtemp);
                array_push($checksumarray,sha1_file($dir.$tempfile));
            }else if($tempfile != "." && $tempfile != ".."){
                mydir($dir.$tempfile."/");
            }
        }
    }
    function after ($caracter, $fullstring)
    {
        if (!is_bool(strpos($fullstring, $caracter)))
        return substr($fullstring, strpos($fullstring,$caracter)+strlen($caracter));
    };
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <form action="#" method="post" enctype="multipart/form-data">
        <input type="text" name="version" id="version" placeholder="Version"><br>
        <input type="file" name="file" id="file"><br>
        <input type="submit" value="Enviar nueva version">
    </form>
</body>
</html>