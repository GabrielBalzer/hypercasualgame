# Software Requirements Specification for Ted's Quest




Version 1.0







Revision History

| **Date** | **Version** | **Description** | **Author** |
| --- | --- | --- | --- |
| \&lt;dd/mmm/yy\&gt; | \&lt;x.x\&gt; | \&lt;details\&gt; | \&lt;name\&gt; |
|   |   |   |   |
|   |   |   |   |
|   |   |   |   |

# Table of Contents

1. [Introduction](#1-introduction)         
    1. [Purpose](#11-purpose)     
    2. [Scope](#12-scope)     
    3. [Definitions, Acronyms and Abbreviations](#13-definitions-acronyms-and-abbreviations)     
    4. [References](#14-references)     
    5. [Overview](#15-overview)     
2. [Overall Description](#2-overall-description)    
3. [Specific Requirements](#3-specific-requirements)
    1. [Functionality](#31-functionality)
        1. [Functional Requirement One](#311-functional-requirement-one>)        
    2. [Usability  ](#32-Usability)   
        1. [Usability Requirement One](#321-usability-requirement-one>)
    3. [Reliability](#33-reliability)     
        1. [Reliability Requirement One](#331-reliability-requirement-one>)
    4. [Performance](#34-performance)     
        1. [Performance Requirement One](#341-performance-requirement-one>)
    5. [Supportability](#35-supportability)     
        1. [Supportability Requirement One](#351-supportability-requirement-one>)
    6. [Design Constraints](#36-design-constraints)     
        1. [Design Constraint One](#361-design-constraint-one)
    7. [Online User Documentation and Help System Requirements](#37-on-line-user-documentation-and-help-system-requirements)
    8. [Purchased Components](#38-purchased-components)     
    9. [Interfaces](#39-interfaces)     
        1. [User Interfaces ](#391-user-interfaces)          
        2. [Hardware Interfaces](#392-hardware-interfaces)           
        3. [Software Interfaces](#393-software-interfaces)           
        4. [Communications Interfaces](#394-communications-interfaces)           
    10. [Licensing Requirements ](#310-licensing-requirements)    
    11. [Legal, Copyright and Other Notices](#311-legal-copyright-and-other-notices)     
    12. [Applicable Standards](#312-applicable-standards)  
4. [Supporting Information](#4-supporting-information)   

# 1. Introduction

This document describes the **SRS** of the game **Ted's Quest** by **Ted's Entertainment**. 
It includes the purpose, scope, definitions, acronyms, abbrevations, references to other
documents and an overview of the **SRS**.

## 1.1 Purpose

The purpose of this document is to build a hypercasualed game for computer and mobile applications.

## 1.2 Scope

The game is aimed to be enjoyable, fun and to challenge one or many. Based on a Server-Client-connection, it shall connect multiple users in a further step, to play against each other.

## 1.3 Definitions, Acronyms, and Abbreviations

OS operating system</br>
UCD use case diagram</br>

## 1.4 References

<a href="https://hypercasual.wordpress.com/">Blog</a></br>
<a href="https://dhbw-karlsruhe.myjetbrains.com/youtrack/dashboard?id=f29a1b9e-a4f4-4c06-8ad9-c7f0e6cc7e58">YouTrack Documentation</a></br>
<a href="https://github.com/GabrielBalzer/hypercasualgame">General GitHub Repository</a></br>
<a href="https://github.com/GabrielBalzer/hypercasualgame/tree/master/hellocucumber">Cucumber Testing GitHub</a></br>
<a href="https://github.com/GabrielBalzer/hypercasualgame/tree/master/tedsquest">Source Code Game GitHub</a></br>
<a href="https://github.com/GabrielBalzer/hypercasualgame/blob/master/SAD.pdf">SAD</a></br>
<a href="https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use-Case_diagram_updated.png">Overall Use-Case Diagram</a></br>

## 1.5 Overview

This section describes the overview on the document. First ther is an overall description.
After, there will be many requirements listed by their belonging. 

# 2. Overall Description

**Product Perspective:**
The user interface is to be on any computer and is not depending on the installed operating system (OS). 
Therefore we need an hardware interface to the mouse and the keyboard.
On Android-based smartphones and tablets we are going to use the display to control the application. 

In both cases, the application is directly installed on the OS. There will be a system interface to the server,
mainly for the global challenging mode. However, the data of singleplayers will also be able to connect to 
the server to save their local data and play in global challenges.

<div align="center"><img src="https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use-Case_diagram.png" alt="UCD Ted's Quest" /></div>

**Design and Implementation Constraints:**
There are some contraints regarding the design and the implementation.
For dessign, there are issues with the vary of the displays on smartphones, tablets and computers.
Even the control differs from device to device as described in the previous subchapter.
However, the server is the centralized data storage. Its behaviour depends on the amount of available 
SQL queries. The provided way of communication between players over our server is depending on the 
user device and the server device.
There also are constraints for the memory allocation in all these devices. We want to provide an 
application with little installation effort regarding the memory size and temporary allocation.

**User Charactistics:**
Based on the use case diagrams (UCD) the user can check the application's settings like managing 
the account he logged in, change the sound or the appearence or start the game itself. 

**Use Cases:**</br>
<ul>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_Mainmenu.md">Use Case: Main Menu</a></br></li>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_Settings.md">Use Case: Settings</a></br></li>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_Storymenu.md">Use Case: Story Menu</a></br></li>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_Soundsettings.md">Use Case: Soundsettings</a></br></li>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_MoveRight.md">Use Case: Move Right</a></br></li>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_Jump.md">Use Case: Jump</a></br></li>
<li><a href = "https://github.com/GabrielBalzer/hypercasualgame/blob/master/documentation/Use%20Cases/UC_Shoot.md">Use Case: Shoot</a></br></li>
</ul>

**Product Functions:**
(n/a)

**Assumptions:**
(n/a)

# 3. Specific Requirements

<div align="center"><img src="https://github.com/GabrielBalzer/hypercasualgame/blob/master/exchange/project-diagramm.jpg" alt="UCD Ted's Quest" /></div>

## 3.1 Functionality

### 3.1.1 Functional Requirement One - Login

A functional requirement shall be the login account. The user shall be able to choose between 
a new local account or login with his Google account.

### 3.1.2 Functional Requirement Two - Manage Account

It shall be possible for the user to manage his account. Therefore it shall be possible to 
logout, delete the account or update any personal information.

### 3.1.3 Functional Requirement Three - Manage Sound

It shall be possible to change the sound from the application to either turn in on or off 
globally.

### 3.1.4 Functional Requirement Four - User Interface

The application shall provide two views, a dark and a light mode.

### 3.1.5 Functional Requirement Five - About

The application shall provide a short description about the application and its developer team.
It shall also provide some basic help for the user.

### 3.1.6 Functional Requirement Six - Choose a Level

It shall be possible to have a simple overview over the possible levels. Only the actual and 
the previous levels, that have been ended successfully shall always be accessible. Else, if
the previous level has not been ended successfully, the level shall be locked.

### 3.1.7 Functional Requirement Seven - Customization

It shall be possible to customize the main character, the stickman. 

### 3.1.8 Functional Requirement Eight - Upgrade

It shall be possible to upgrade the weapons and powerups by purchasing objects by both, real 
money and collected coins from the playthrough.

### 3.1.9 Functional Requirement Nine - Update the Application

The application shall update itself automatically, without user input.

## 3.2 Usability

### 3.2.1 Usability Requirement One - Simple handling of the Application

It shall be easy to start and play the application. It shall be easy to learn and handle the 
control of the application itself. The user interface shall be simple and intuitive. 

### 3.2.2 Usability Requirement Two - Simple handling of the Main Character

It shall be easy to control the main character, on the computer as well as on the smartphone.
The control shall be intuitive and simple.

### 3.2.3 Usability Requirement Three - Application Crash

When the application crashes for minor reasons that do not affect the user, the user 
shall not get to know it. The application shall rebuild itself.

### 3.2.4 Usability Requirement Four - Tutorial

There shall be a tutorial in the beginning of the game after the first start. It shall be 
possible to always access the tutorial.

### 3.2.5 Usability Requirement Five - Report to the Developers

The user shall have a way to report a problem or give positive and negative feedback.

### 3.2.6 Usability Requirement Six - Leave Game 

It shall be possible to leave the game at any time. Either by clicking on "back", on clicking 
the "home button" both on the smartphone or by clicking "X" which represents the exit button.
Also when leaving the focus on the game on the operating system, the application shall pause.

## 3.3 Reliability

### 3.3.1 Reliability Requirement One - Fluent Gameplay

While using the application, it shall be fluent. There shall no stuttering or long pauses.

### 3.3.2 Reliability Requirement Two - Application Crash

When the application crashes, it shall not crash. It shall recover itself in a way, the user 
will not be affected.

### 3.3.3 Reliability Requirement Three - Time to Repair

The time to repair the system shall not overexceed one minute.

## 3.4 Performance

### 3.4.1 Performance Requirement One - Performance

The application shall run at atleast 30 FPS.

### 3.4.2 Performance Requirement Two - User Capacity

The game shall be for a single user only per installation.

### 3.4.3 Performance Requirement Three - Local Resources

The application shall run at a minimum disk space and shall run independendly from the 
operating system. It application shall also not use too much memory space.

## 3.5 Supportability

### 3.5.1 Supportability Requirement One - Maintainable Code

The source code shall be kept simple and so, it shall be easy to maintain. The code shall 
be divided into a MVC-relied way.

### 3.5.2 Supportability Requirement Two - Reported Bugs

Reported bugs shall be updated in the source code every month. So, many bugs can be fixed in 
one time and the time to maintain the code is reduced.

## 3.6 Design Constraints

### 3.6.1 Design Constraint One - Architecture

Since the architecture is to be MVC, the source code is divided in three separate parts.

### 3.6.2 Design Constraint Two - Models

Since the team only uses open-source tools, the team is kept low with every tool. Otherwise
there shall be used way more tools.

### 3.6.3 Design Constraint Three - Development Tools

We decided to use the following tools, to help developing the game:</br>

<ul>
<li><b>YouTrack</b> Project Management and Issue Tracker Sytem</br></li>
<li><b>GitHub</b> Version Control System</br></li>
<li><b>Unity</b> Game Engine</br></li>
<li><b>Visual Studio</b> IDE used for scripting within Unity</br></li>
</ul>

## 3.7 On-line User Documentation and Help System Requirements

There shall be a link to report bugs in the settings of the application. 

## 3.8 Purchased Components

(n/a) 

## 3.9 Interfaces

The application shall be runt on smartphones and computers. 
The used interface is decided by the Unity Framwork.

### 3.9.1 User Interfaces

There shall be a dark mode and a light mode, chosen by the user. Initially the light mode is 
turned on.

### 3.9.2 Hardware Interfaces

The application is mostly hardware indepenent. At the time for the first release, there shall 
be no support for smartphones of the company Apple.

### 3.9.3 Software Interfaces

(n/a)

### 3.9.4 Communications Interfaces

(n/a)

## 3.10 Licensing Requirements

The application shall be open source under the GPL version 2 or any later version.

## 3.11 Legal, Copyright, and Other Notices

The developers are not responsible for any impact, the game might have on the user.

## 3.12 Applicable Standards

(n/a) 

# 4. Supporting Information

(n/a)
