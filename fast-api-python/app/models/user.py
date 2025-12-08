from sqlalchemy import Column, Integer, String, Date
from sqlalchemy.ext.declarative import declarative_base

Base = declarative_base()

class User(Base):
    __tablename__ = "users"

    id = Column(Integer, primary_key=True, index=True)
    name = Column(String(100), nullable=False)
    prefix = Column(String(10), nullable=True)
    suffix = Column(String(20), nullable=True)
    birth_date = Column(Date, nullable=False)
    birth_place = Column(String(50), nullable=False)
    gender = Column(String(10), nullable=False)
    religion = Column(String(10), nullable=False)
    maritial_status = Column(String(20), nullable=False)
    picture_path = Column(String(250), nullable=True)
