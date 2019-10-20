# Software Requirements Specification
## For HypercasualGame
Version 1.0  

Table of Contents
=================
* [Revision History](#revision-history)
* 1 [Introduction](#1-introduction)
  * 1.1 [Document Purpose](#11-document-purpose)
  * 1.2 [Product Scope](#12-product-scope)
  * 1.3 [Definitions, Acronyms and Abbreviations](#13-definitions-acronyms-and-abbreviations)
  * 1.4 [References](#14-references)
  * 1.5 [Overview](#15-overview)
* 2 [Overall Description](#2-overall-description)
* 3 [Requirements](#3-requirements)
  * 3.1 [External Interfaces](#31-external-interfaces)
    * 3.1.1 [User Interfaces](#311-user-interfaces)
    * 3.1.2 [Hardware Interfaces](#312-hardware-interfaces)
    * 3.1.3 [Software Interfaces](#313-software-interfaces)
  * 3.2 [Functional](#32-functional)
  * 3.3 [Quality of Service](#33-quality-of-service)
    * 3.3.1 [Performance](#331-performance)
    * 3.3.2 [Security](#332-security)
    * 3.3.3 [Reliability](#333-reliability)
    * 3.3.4 [Availability](#334-availability)
  * 3.4 [Compliance](#34-compliance)
  * 3.5 [Design and Implementation](#35-design-and-implementation)
    * 3.5.1 [Installation](#351-installation)
    * 3.5.2 [Distribution](#352-distribution)
    * 3.5.3 [Maintainability](#353-maintainability)
    * 3.5.4 [Reusability](#354-reusability)
    * 3.5.5 [Portability](#355-portability)
    * 3.5.6 [Cost](#356-cost)
    * 3.5.7 [Deadline](#357-deadline)
    * 3.5.8 [Proof of Concept](#358-proof-of-concept)
* 4 [Verification](#4-verification)
* 5 [Appendixes](#5-appendixes)

## Revision History
| Name | Date    | Reason For Changes  | Version   |
| ---- | ------- | ------------------- | --------- |
|      |         |                     |           |
|      |         |                     |           |
|      |         |                     |           |
<!--
      * 3.1.1.1 [Usability](#-external-interfaces)
      * 3.1.1.2 [Convenience](#-external-interfaces)
      * 3.1.2.1 [Interoperability](#-external-interfaces)
      * 3.1.3.1 [Interoperability](#-external-interfaces) -->

## 1. Introduction
<!-- The introduction of the SRS should provide an overview of the entire SRS -->
### 1.1 Document Purpose
Describe the purpose of the SRS and its intended audience.
### 1.2 Product Scope
Identify the product whose software requirements are specified in this document, including the revision or release number. Explain what the product that is covered by this SRS will do, particularly if this SRS describes only part of the system or a single subsystem. Provide a short description of the software being specified and its purpose, including relevant benefits, objectives, and goals. Relate the software to corporate goals or business strategies. If a separate vision and scope document is available, refer to it rather than duplicating its contents here.
This SRS referes to the entire HypercasualGame project. 
### 1.3 Definitions, Acronyms and Abbreviations
### 1.4 References
List any other documents or Web addresses to which this SRS refers. These may include user interface style guides, contracts, standards, system requirements specifications, use case documents, or a vision and scope document. Provide enough information so that the reader could access a copy of each reference, including title, author, version number, date, and source or location.
### 1.5 Overview
Describe what the rest of SRS contains and how it is organized.
## 2. Overall Description
<!-- This section of the SRS should describe the general factors that affect the product and its requirements. This section does not state specific requirements. Instead, it provides a background for those requirements, which are defined in detail in Section 3 of the SRS, and makes them easier to understand. -->

## 3. Requirements
<!-- Specify all of the software requirements to a level of detail sufficient to enable designers to design a software system to satisfy those requirements. Specify all of the software requirements to a level of detail sufficient to enable testers to test that the software system satisfies those requirements. At a minimum, describe every input (stimulus) into the software system, every output (response) from the software system, and all functions performed by the software system in response to an input or in support of an output.

The specific requirements should:
a) Be stated in conformance with all the characteristics described in subclause 5.2 of ISO/IEC/IEEE 29148:2011.
b) Be cross-referenced to earlier documents that relate.
c) Be uniquely identifiable.  -->
### 3.1 External Interfaces
<!-- Define all in puts into and outputs from the software system. Each interface defined should include the following content:
a) Name of item;
b) Description of purpose;
c) Source of input or destination of output;
d) Valid range, accuracy, and/or tolerance;
e) Units of measure;
f) Timing;
g) Relationships to other inputs/outputs;
h) Screen formats/organization;
i) Window formats/organization;
j) Data formats;
k) Command formats;
l) Endmessages. -->
#### 3.1.1 User interfaces
Describe the logical characteristics of each interface between the software product and the users. This may include sample screen images, any GUI standards or product family style guides that are to be followed, screen layout constraints, standard buttons and functions (e.g., help) that will appear on every screen, keyboard shortcuts, error message display standards, and so on. Define the software components for which a user interface is needed. Details of the user interface design should be documented in a separate user interface specification.
#### 3.1.2 Hardware interfaces
Describe the logical and physical characteristics of each interface between the software product and the hardware components of the system. This may include the supported device types, the nature of the data and control interactions between the software and the hardware, and communication protocols to be used.
#### 3.1.3 Software interfaces
Describe the connections between this product and other specific software components (name and version), including databases, operating systems, tools, libraries, and integrated commercial components. Identify the data items or messages coming into the system and going out and describe the purpose of each. Describe the services needed and the nature of communications. Refer to documents that describe detailed application programming interface protocols. Identify data that will be shared across software components. If the data sharing mechanism must be implemented in a specific way (for example, use of a global data area in a multitasking operating system), specify this as an implementation constraint.
### 3.2 Functional
### 3.3 Quality of Service
<!-- Quality requirements state additional, quality-related properties that the functional effects of the  software should have. -->
#### 3.3.1 Performance
If there are performance requirements for the product under various circumstances, state them here and explain their rationale, to help the developers understand the intent and make suitable design choices. Specify the timing relationships for real time systems. Make such requirements as specific as possible. You may need to state performance requirements for individual functional requirements or features.
#### 3.3.2 Security
Specify any requirements regarding security or privacy issues surrounding use of the product or protection of the data used or created by the product. Define any user identity authentication requirements. Refer to any external policies or regulations containing security issues that affect the product. Define any security or privacy certifications that must be satisfied.
#### 3.3.3 Reliability
Specify the factors required to establish the required reliability of the software system at time of delivery.
#### 3.3.4 Availability
Specify the factors required to guarantee a defined availability level for the entire system such as checkpoint, recovery, and restart.
### 3.4 Compliance
Specify the requirements derived from existing standards or regulations, including:  
a) Report format;  
b) Data naming;  
c) Accounting procedures;  
d) Audit tracing.  

For example, this could specify the requirement for software to trace processing activity. Such traces are needed for some applications to meet minimum regulatory or financial standards. An audit trace requirement may, for example, state that all changes to a payroll database shall be recorded in a trace file with before and after values.
### 3.5 Design and Implementation
#### 3.5.1 Installation
Constraints to ensure that the software-to-be will run smoothly on the target implementation platform.
#### 3.5.2 Distribution
Constraints on software components to fit the geographically distributed structure of the host organization, the distribution of data to be processed, or the distribution of devices to be controlled.
#### 3.5.3 Maintainability
Specify attributes of software that relate to the ease of maintenance of the software itself. These may include requirements for certain modularity, interfaces, or complexity limitation. Requirements should not be placed here just because they are thought to be good design practices.
#### 3.5.4 Reusability
#### 3.5.5 Portability
Specify attributes of software that relate to the ease of porting the software to other host machines and/or operating systems.
#### 3.5.6 Cost
#### 3.5.7 Deadline
#### 3.5.8 Proof of Concept
## 4. Verification
Provide the verification approaches and methods planned to qualify the software. The information items for verification are recommended to be given in a parallel manner with the information items in Section 3.
## 5. Appendixes
