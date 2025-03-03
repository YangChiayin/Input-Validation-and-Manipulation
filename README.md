# Input Validation and Manipulation

## Project Overview
This project is a C# Windows Forms application that demonstrates input validation, string manipulation, and playing card validation. The app features a set of functionalities for validating user input (such as alphabetic characters, numeric characters, and punctuation), manipulating text (splitting and extracting alphanumeric characters), and validating and saving playing card information to a file.

## Features
- **Validation Groupbox**:
  - Check if input is **not empty**.
  - Check if input has **minimum length**.
  - Validate if input contains **only alphabetic characters**.
  - Validate if input contains **only numeric characters**.
  - Check if input contains **at least one punctuation character**.

- **Manipulation Groupbox**:
  - Split input text based on whitespace and display each part on a new line.
  - Remove non-alphabetic characters and display the remaining alphanumeric characters.

- **Playing Card Groupbox**:
  - Validate the **suit** (spade, heart, club, diamond) and **value** (1-13) of a playing card.
  - Save valid playing card details (suit, value) to a file.

## Technologies Used
- C# .NET (Windows Forms)
- StreamWriter for file I/O
- LINQ for input validation and string manipulation
