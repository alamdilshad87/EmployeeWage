# 💼 Employee Wage Computation System

This project implements a **real-world Employee Wage Computation System** using **C# and .NET**, developed incrementally through **Use Cases UC1–UC14**.

Each use case builds upon the previous one, evolving the solution from a basic employee attendance check to a **scalable, API-based system** capable of handling **multiple companies, daily wage storage, and company-wise wage queries**.

---

## 📜 Problem Statement

An organization wants to compute employee wages based on:
- Employee attendance (Present / Absent)
- Part-time and full-time work
- Daily working hours
- Monthly working limits
- Multiple companies with different wage rules

The system should:
- Calculate daily wages
- Calculate monthly wages with constraints
- Store wages for multiple companies
- Allow querying total wage by company name

The solution evolves progressively across multiple use cases.

---

## 🧩 Use Cases Overview

### **UC1 – Check Employee Presence**
Check whether an employee is **Present or Absent** using conditional statements.

### **UC2 – Calculate Daily Employee Wage**
Calculate daily wage assuming full-day work.

### **UC3 – Add Part-Time Employee & Wage**
Introduce **part-time employee** with different working hours and wages for part-time and full-time employees.

### **UC4 – Solve Using Switch Statement**
Use `switch-case` to determine employee working hours, improving readability over multiple `if-else`.

### **UC5 – Calculate Wages for a Month**
Calculate wages assuming **20 working days** in a month.

### **UC6 – Calculate Wages Till Maximum Condition**
Stop wage calculation when:
- Total working hours reach **100**, OR
- Total working days reach **20**

### **UC7 – Refactor Using Class Methods**
Refactor logic into **classes and methods** and introduce Object-Oriented Programming concepts.

### **UC8 – Compute Employee Wage for Multiple Companies**
Extend solution to support **multiple companies**, where each company can have different wage rules.

### **UC9 – Save Total Wage for Each Company**
Store the **total monthly wage** for each company, enabling later retrieval.

### **UC10 – Manage Wages Using Interface**
Introduce **interface-based design** to decouple implementation from usage.

### **UC11 – API-Based Employee Wage Management**
Use **API-style methods** to manage employee wages, improving scalability and maintainability.

### **UC12 – Refactor to Use List of Companies**
Manage multiple companies using a **List**, enabling centralized wage management.

### **UC13 – Store Daily Wage Along with Total Wage**
Store **day-wise wages** for each company while maintaining both daily wages and total monthly wage.

### **UC14 – Get Total Wage When Queried by Company**
Retrieve total wage using **company name**.

**Example:**
```
Daily Wages for company : DMart
80
80
Total Emp Wage for company : DMart is : 160
Daily Wages for company : Reliance
0
40
80
40
Total Emp Wage for company : Reliance is : 160
Daily Wages for company : TCS
200
100
0
0
0
0
200
100
200
0
100
200
100
0
100
100
100
100
100
200
200
0
Total Emp Wage for company : TCS is : 2100
Queried DMart Wage : 160
Queried Reliance Wage : 160
Queried TCS Wage : 2100
```

---

## 🧭 Project Workflow

```
Employee Presence Check
         ↓
   Daily Wage Calculation
         ↓
  Monthly Wage Calculation
         ↓
Class & Method Refactoring
         ↓
 Multiple Company Support
         ↓
  Interface-Based Design
         ↓
 API-Based Wage Management
         ↓
   Daily Wage Storage
         ↓
Company-wise Wage Query
```

---

## 🌿 Branching Strategy

Each use case is implemented in a **separate feature branch** and merged progressively.

| Branch Name | Description |
|------------|-------------|
| feature/UC1_EmployeePresence | Employee presence check |
| feature/UC2_DailyWage | Daily wage calculation |
| feature/UC3_PartTimeEmployee | Part-time employee support |
| feature/UC4_SwitchCase | Switch-based logic |
| feature/UC5_MonthlyWage | Monthly wage calculation |
| feature/UC6_MaxHoursOrDays | Max hours / days condition |
| feature/UC7_ClassRefactor | Class & method refactor |
| feature/UC8_MultipleCompanies | Multiple companies support |
| feature/UC9_SaveTotalWage | Store total wage |
| feature/UC10_InterfaceApproach | Interface-based design |
| feature/UC11_APIApproach | API-based management |
| feature/UC12_CompanyList | List-based company handling |
| feature/UC13_DailyWageStorage | Store daily wages |
| feature/UC14_QueryByCompany | Query wage by company |

**Workflow followed:**
```
Feature Branch → dev → main
```

---

## ⚙️ Tech Stack

- **Language:** C#
- **Framework:** .NET Console Application
- **IDE:** Visual Studio
- **Version Control:** Git & GitHub

---

## 🏁 Final Outcome

A complete **Employee Wage Computation System** that:
- Handles multiple companies
- Calculates daily and monthly wages
- Stores daily wages along with total wages
- Supports company-wise wage queries
- Uses OOP, Interfaces, and API-based design
- Follows a clean Git branching and merge strategy

---

## 🧑‍💻 Developed By

**MD Dilshad Alam**  
Implemented Use Cases **UC1–UC14** using **C# and .NET** with a structured, incremental development approach.

---

## Guided By BridgeLabz 
