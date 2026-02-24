package com.ibiza.demo.entity;

import java.time.LocalDateTime;
import java.util.List;

import com.fasterxml.jackson.annotation.JsonProperty;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.Table;
import jakarta.persistence.ManyToOne;
import lombok.Getter;
import lombok.Setter;


@Getter
@Setter
@Entity
@Table(name = "classrooms")
public class Classroom {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne
    @JoinColumn(name = "teacher_id")
    private Teacher teacher;

    // @OneToMany(mappedBy = "classroom")
    // private List<Student> students;

    @Column(name = "class_code")
    private String classCode;

    @Column(name = "level")
    private String level;

    @Column(name = "semester")
    private String semester;


    @Column(name = "type")
    private String type;

    @Column(name = "room")
    private String room;

    @Column(name = "year")
    private String year;

    @Column(name = "is_active")
    private String isActive;

    @Column(name = "created_at")
    private LocalDateTime createdAt;
}
