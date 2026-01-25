<?php

class FlasherMessage{
    public static function setFlashMessage($message, $type){
        $_SESSION["flashData"] = [
            "pesan" => $message,
            "type"  => $type
        ];
    }

    public static function getFlashMessage(){
        if(isset($_SESSION["flashData"])){
            echo '
                <div class="alert alert-' . $_SESSION['flashData']['type'] . ' alert-dismissible fade show" role="alert">' . $_SESSION['flashData']['message'] . '
                </div>
            ';
            unset($_SESSION["flashData"]);
        }
    }
}