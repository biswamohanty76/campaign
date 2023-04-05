package com.texhibit.candidate.utils;

import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.text.PDFTextStripper;
import org.springframework.stereotype.Component;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

@Component
public class Parser {
    public static String parse(String path) throws IOException {
        File file = new File(path);
        FileInputStream fis = new FileInputStream(file);
        PDDocument document = PDDocument.load(fis);
        System.out.println(document.getPages().getCount());
        PDFTextStripper textStripper = new PDFTextStripper();
        String docText = textStripper.getText(document);
        return docText;
    }

}
