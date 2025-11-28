# 🤖 Copilot Code Review Instructions

These are the custom rules that GitHub Copilot must follow when reviewing code in this repository.  
Copilot should apply these rules to **every pull request** and **every code review request**.
---

## 🏗️ Architecture Consistency
- New files must follow the existing folder and project structure (e.g., services go in /Services).
- Request changes when a commit does not fit within the existing architecture.

---

## 🗂️ File & Class Name Consistency
- A file name must match the primary class name inside it (e.g., MessagesService.cs → MessagesService).
- Request changes when the file name and class name do not correspond.

---

## ❗ Avoid Negative or Confusing Names
- Variable names must be positive and clear (e.g., use isDone instead of isNotDone).
- Request changes when naming is negative, double-negative, or confusing.

---

## ✏️ Consistent Formatting
- Code must use a uniform indentation style (tabs/spaces) across all methods and files.
- Request changes when formatting is inconsistent or breaks the project’s convention.

---

## 🔤 Naming Conventions
- Follow standard C# naming: variables use camelCase, and classes, methods, and public members use PascalCase.
- Request changes when naming does not follow these conventions.

---

## 🧼 Clean Code Principles
- Functions should stay focused on a single responsibility and avoid unnecessary logic, loops, or logging.
- The tool should warn when a method becomes too long, too complex, or mixes multiple concerns.

---

## 🧪 Unit Test Coverage
- New logic should be supported by appropriate unit tests, especially for services and controllers.
- The tool should warn when a commit adds functionality without corresponding tests.

---

## 🏁 End of Copilot Instructions  
Copilot should follow these rules in every code review in this repository.
