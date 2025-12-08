from fastapi import FastAPI
from app.routers import user

app = FastAPI(title="FastAPI MySQL Example")

app.include_router(user.router, prefix="/users", tags=["Users"])

@app.get("/")
def home():
    return {"message": "Hello FastAPI!"}
