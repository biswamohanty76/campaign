package com.culturecub.parser.services;

import com.culturecub.parser.utilities.Parser;
import org.apache.poi.openxml4j.exceptions.OpenXML4JException;
import org.apache.xmlbeans.XmlException;
import org.springframework.stereotype.Service;

import java.io.File;
import java.io.IOException;


@Service
public class ParseService {

    public String parse(String filePath) throws IOException, OpenXML4JException, XmlException {
        File file = new File(filePath);
        String docText = "";
        String extension = Parser.getFileExtension(filePath);

        switch (extension){
            case "pdf":
                docText = Parser.parsePDF(String.valueOf(file));
                break;
            case "docx":
                docText = Parser.parseDOCX(file);
                break;
            case "doc":
                docText = Parser.parseDOC(file);
                break;

        }

        return docText;
    }


}
