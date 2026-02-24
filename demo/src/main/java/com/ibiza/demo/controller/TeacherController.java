package com.ibiza.demo.controller;

import com.ibiza.demo.entity.Teacher;
import com.ibiza.demo.repository.TeacherRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/teachers")
public class TeacherController {
    private final TeacherRepository teacherRepository;

    public TeacherController(TeacherRepository teacherRepository) {
        this.teacherRepository = teacherRepository;
    }

    @GetMapping
    public List<Teacher> getAll() {
        return teacherRepository.findAll();
    }

    @PostMapping
    public Teacher create(@RequestBody Teacher teacher) {
        return teacherRepository.save(teacher);
    }
}
