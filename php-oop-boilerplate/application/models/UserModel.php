<?php

class UserModel{
    private $table = "replace_with_table_in_your_database";
    private $db;

    public function __construct()
    {
        $this->db = new Database();
    }

    public function getData(){
        $query = "SELECT * FROM " . $this->table;
        $this->db->query($query);
        return $this->db->resultSet();
    }
}