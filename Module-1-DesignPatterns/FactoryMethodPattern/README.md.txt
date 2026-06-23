# Factory Method Pattern Example

## Objective

Implement the Factory Method Design Pattern to create different types of documents without exposing object creation logic to the client.

## Design Pattern Used

Factory Method Pattern

## Components

### Documents

* IDocument
* PdfDocument
* WordDocument
* ExcelDocument

### Factories

* DocumentFactory
* PdfFactory
* WordFactory
* ExcelFactory

## Benefits

* Loose Coupling
* Easy Maintenance
* Supports Open Closed Principle (OCP)
* Supports Dependency Inversion Principle (DIP)
* Centralized Object Creation

## Expected Output

PDF Document Opened

Word Document Opened

Excel Document Opened

## Author

Jayendra
