package main

import (
	"project-go/config"
	"project-go/controllers"

	"github.com/gin-gonic/gin"
)

func main() {
	// 1. Connect database
	config.ConnectDB()
	db := config.DB

	// 2. Create Gin router
	r := gin.Default()

	// 3. Define route
	r.GET("/users", controllers.GetUsers)
	r.POST("/users", controllers.CreateUser)
	r.PUT("/users/:id", controllers.UpdateUser)
	r.DELETE("/users/:id", controllers.DeleteUser(db))

	// 4. Run server
	r.Run(":8080") // default port 8080
}
