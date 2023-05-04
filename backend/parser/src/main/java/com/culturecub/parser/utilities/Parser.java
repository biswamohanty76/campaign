package com.culturecub.parser.utilities;

import com.fasterxml.jackson.databind.exc.InvalidFormatException;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.text.PDFTextStripper;
import org.apache.poi.hwpf.HWPFDocument;
import org.apache.poi.hwpf.extractor.WordExtractor;
import org.apache.poi.openxml4j.exceptions.OpenXML4JException;
import org.apache.poi.openxml4j.opc.OPCPackage;
import org.apache.poi.xwpf.extractor.XWPFWordExtractor;
import org.apache.poi.xwpf.usermodel.XWPFDocument;
import org.apache.xmlbeans.XmlException;
import org.springframework.stereotype.Component;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;

@Component
public class Parser {
    public static String parsePDF(String path) throws IOException {

        FileInputStream fis = new FileInputStream(path);
        PDDocument document = PDDocument.load(fis);
        PDFTextStripper textStripper = new PDFTextStripper();
        String docText = textStripper.getText(document);
        return docText;
    }


    public static String getFileExtension(String filepath) {
        int i = filepath.lastIndexOf('.');
        String ext = i > 0 ? filepath.substring(i + 1) : "";
        return ext;
    }

    public static String parseDOCX(File file) throws IOException, InvalidFormatException, org.apache.poi.openxml4j.exceptions.InvalidFormatException {
        FileInputStream fis = new FileInputStream(file);
        XWPFDocument xdoc = new XWPFDocument(OPCPackage.open(fis));
        XWPFWordExtractor extractor = new XWPFWordExtractor(xdoc);
        return extractor.getText();
    }

    public static String parseDOC(File file) throws IOException, OpenXML4JException, XmlException {

        FileInputStream fs = new FileInputStream(file.getAbsolutePath());
        //POIFSFileSystem fs = new POIFSFileSystem(new FileInputStream(file.getAbsolutePath()));
        HWPFDocument document = new HWPFDocument(fs);
        WordExtractor extractor = new WordExtractor(document);
        String docText = extractor.getText();
        return docText;
    }

}
