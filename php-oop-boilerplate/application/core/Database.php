<?php

class Database{
    private $dbHost = DBHOST;
    private $dbUser = DBUSER;
    private $dbPass = DBPASS;
    private $dbName = DBNAME;

    private $dbh;
    private $stmt;

    public function __construct()
    {
        $dsn = "mysql:hostname=" . $this->dbHost . ";.dbname=" . $this->dbName;

        $options = [
            PDO::ATTR_PERSISTENT => true,
            PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION
        ];

        try{
            $this->dbh = new PDO($dsn, $this->dbUser, $this->dbPass, $options);
        }catch(PDOException $e){
            die($e->getMessage());
        }
    }

    public function query($query){
        $this->stmt = $this->dbh->prepare($query);
    }

    public function bind($param, $value, $type=[]){
        if(is_null($type)){
            switch(true){
                case is_null($value) :
                    $type = PDO::PARAM_NULL;
                break;
                case is_bool($value) :
                    $type = PDO::PARAM_BOOL;
                break;
                case is_int($value) :
                    $type = PDO::PARAM_INT;
                break;
                default :
                    $type = PDO::PARAM_STR;
            }
        }
        $this->stmt->bindValue($param, $value, $type=[]);
    }

    public function execute(){
        $this->stmt->execute();
    }

    public function resultSet(){
        $this->execute();
        return $this->stmt->fetchAll(PDO::FETCH_ASSOC);
    }

    public function single(){
        $this->execute();
        return $this->stmt->fetchAll(PDO::FETCH_ASSOC);
    }

    public function rowCount(){
        return $this->stmt->rowCount();
    }

}