package com.ibiza.demo.controller;

import com.ibiza.demo.entity.Classroom;
import com.ibiza.demo.repository.ClassroomRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/classrooms")
public class ClassroomController {
    private final ClassroomRepository classroomRepository;

    public ClassroomController(ClassroomRepository classroomRepository) {
        this.classroomRepository = classroomRepository;
    }

    @GetMapping
    public List<Classroom> getAll() {
        return classroomRepository.findAll();
    }

    @PostMapping
    public Classroom create(@RequestBody Classroom classroom) {
        return classroomRepository.save(classroom);
    }
}
