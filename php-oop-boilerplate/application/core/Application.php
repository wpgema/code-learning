<?php

class Application{
    protected $controller = "Home";
    protected $method = "index";
    protected $params = [];
    public function __construct()
    {
        $url = $this->parseUrl();
        if(file_exists("../application/controller/" . $url[0] . ".php")){
            $this->controller = $url[0];
            unset($url[0]);
        }
        require_once "../application/controller/" . $this->controller . ".php";
        $this->controller = new $this->controller();
        if(isset($url[1])){
            if(method_exists($this->controller, $url[1])){
                $this->method = $url[1];
                unset($url[1]);
            }
        }
        $this->params = !empty($url) ? $url : [];
        call_user_func_array([$this->controller, $this->method], $this->params);
    }
    public function parseUrl(){
        if(isset($_GET["url"])){
            $url = rtrim($_GET["url"], "/");
            $url = filter_var($url, FILTER_SANITIZE_URL);
            $url = explode("/", $url);
            return $url;
        }
    }
}
