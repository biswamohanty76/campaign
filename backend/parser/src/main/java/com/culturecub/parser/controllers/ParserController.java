package com.culturecub.parser.controllers;

import com.culturecub.parser.entities.AppDocument;
import com.culturecub.parser.services.ParseService;
import org.apache.poi.openxml4j.exceptions.OpenXML4JException;
import org.apache.xmlbeans.XmlException;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.io.IOException;

@RestController
@RequestMapping("/api")
public class ParserController {

    private final ParseService parseService;

    public ParserController(ParseService parseService) {
        this.parseService = parseService;
    }

    @PostMapping(value = "/parse")
    public String parse(@RequestBody AppDocument document) throws IOException, OpenXML4JException, XmlException {
        String filePath = document.getFilepath();
        String response = parseService.parse(String.valueOf(filePath));
        return response;
    }
}
