# TechNet article November 2018

[DataGridView setup header text using SQL-Server](https://social.technet.microsoft.com/wiki/contents/articles/52160.datagridview-setup-header-text-using-sql-server.aspx)

## Introduction

A common method for setting header text property of a DataGridView is done one of two ways when not working with TableAdapter method to populate a DataGridView. The first is to assign the DataSource of the DataGridView to a DataTable or a List then use something like a dictionary where the key is the underlying field name and the value is the header text, iterate the dictionary to assign header text. The second method is to create columns for the DataGridView in the designer, assign header text and a field to the DataPropery.

This article examines an alternate method for providing header text to column in a DataGridView using a single property for a column in a table within a SQL-Server database. 

## Requires
- Microsoft Visual Studio Jump 2015 or higher.
- Microsoft SQL-Server Jump , at minimum the Express edition
- SSMS (SQL-Server Management Studio).

## Running the code samples
There is one class project for data operations and a Windows Form project. The Windows form project has three forms where Form3 is set as default. Form3 has all the proper assertions while Form1 and Form2 do not. Form2 difference from Form1 in that Form1 has no predefined columns in the DataGridView while Form2 does have predefined columns in the DataGridView,