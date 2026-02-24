package com.ibiza.demo.entity;

import java.time.LocalDateTime;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "students")
public class Student {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @OneToOne
    @JoinColumn(name = "user_id")
    private User user;

    @ManyToOne
    @JoinColumn(name = "classroom_id")
    private Classroom classroom;

    private String name;

    @Column(name = "nisn")
    private String nisn;

    @Column(name = "level")
    private String level;

    @Column(name = "year_of_entry")
    private String yearOfEntry;
    
    private String email;

    @Column(name = "number_phone")
    private String numberPhone;

    private String address;

    @Column(name = "birth_date")
    private String birthDate;

    @Column(name = "birth_place")
    private String birthPlace;

    private String gender;

    private String religion;

    @Column(name = "is_active")
    private int isActive;

    @Column(name = "image_path")
    private String imagePath;

    @Column(name = "status")
    private String status;

    @Column(name = "created_at")
    private LocalDateTime createdAt;
}