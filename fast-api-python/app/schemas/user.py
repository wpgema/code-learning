from pydantic import BaseModel
from datetime import date

class UserSchema(BaseModel):
    id: int
    name: str
    prefix: str | None = None
    suffix: str | None = None
    birth_date: date
    birth_place: str
    gender: str
    religion: str
    maritial_status: str
    picture_path: str | None = None

    class Config:
        orm_mode = True
