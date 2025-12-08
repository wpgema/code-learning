package main

import (
	"project-go/config"
	"project-go/controllers"
	"project-go/models"

	"github.com/gin-gonic/gin"
)

func main() {
	config.ConnectDB()

	_ = config.DB.AutoMigrate(&models.User{})

	r := gin.Default()

	r.GET("/users", controllers.GetUsers)
	r.POST("/users", controllers.CreateUser)
	r.PUT("/users/:id", controllers.UpdateUser)
	r.DELETE("/users/:id", controllers.DeleteUser)

	r.Run(":8080")
}
