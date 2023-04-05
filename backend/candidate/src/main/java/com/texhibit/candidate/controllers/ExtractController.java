package com.texhibit.candidate.controllers;

import com.texhibit.candidate.services.ExtractService;
import org.springframework.web.bind.annotation.*;

import java.io.IOException;

@RestController
@RequestMapping(value = "/api")
public class ExtractController {

    private final ExtractService extractService;

    public ExtractController(ExtractService extractService) {
        this.extractService = extractService;
    }

    @RequestMapping(value = "/parse/{path}", method = RequestMethod.POST)
    public boolean parse(@PathVariable String path) throws IOException {
        boolean isFileParsed = extractService.parseFile(path);
        return true;
    }

}
