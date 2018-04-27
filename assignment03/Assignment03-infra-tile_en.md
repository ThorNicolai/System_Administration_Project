# Assignment 3: Network infrastructure analysis of an office

## Job description

This assignment challenges your abilities to give customer advice regarding the IT design of an office. This includes the research, development and implementation of the network infrastructure with accompanying plans, equipment, submission of tenders, ...

In concrete terms, you will design the network infrastructure for a (fictitious) SME. The plan includes a floor plan of the commercial premises where the company will be located. Based on the wishes of the customer described below, you will work out a proposal with a logical and physical topology of the network infrastructure and at least create two offers with alternatives from which your customer can choose. Your proposals should include what is necessary in terms of IT infrastructure, licenses for software that the employees run on their laptops should not be included. The working hours for realizing the proposal (hardware, cabling, configuration servers, basic configuration laptops) are also included in the proposal.

Assume that your customer typically has no IT background and may not have thought of things that may be useful or even necessary. Do not hesitate to make proposals!

- *Estate:*
	- The company has ten employees (including the manager).
	- The commercial property is an open space, but the company wants to separate a meeting room and a technical room (for, among other things, servers and network equipment). These are indicated on the plan in blue.
    - There is a false ceiling that can be used for cabling.
- *General:*
    - Wireless network for employees and one for guests / customers.
    - User accounts are managed centrally.
    - Company data is stored on a file server that is only accessible to employees.
    - (Nice to have) employees regularly work remotely (at home or at a customer).
    - You take care of the installation and configuration of the necessary server(s) and work out scripts to automate this process.
- *Workplaces:*
    - Every employee has a laptop. The software used is on the one hand the typical basic applications (web browser, etc) and office applications (e-mail, word processor, ...); on the other hand applications for graphic design (Adobe Creative Suite). The purchase of the hardware, installation of the OS and  configuration for use within the company network is part of the quotation, as well as installation of freely available basic software (eg web browser, PDF viewer). The license costs and installation of additional commercial software * not *.
    - A workplace with at least one Ethernet patch point is provided for each employee.
    - (Nice to have:) an IP telephone is provided for each workplace.
- *Conference room:*
    - Some Ethernet patch points (but in general it is assumed that network access is done via Wifi).
    - A beamer.
    - (Nice to have:) an IP telephone.

Your technical supervisor plays the role of the customer here. You can ask him additional questions about the desired infrastructure during a follow-up meeting of via e-mail.

## Acceptance criteria

- The elaborated network infrastructure must meet the specifications of the customer
- There is a price estimate for all necessary appliances, cabling, working hours, ... in the form of at least 2 different offers.
- A proof-of-concept is available in PacketTracer that can also be worked out in a physical setup.
- The proposal allows a customer to make the right decision about the purchase, installation and configuration of all necessary devices, cabling, ...

## Deliverables

** Presentation and demo ** during the final contact moment of:

- The network infrastructure proposal. In doing so, you mainly focus on the general set-up of the network infrastructure, the advantages / disadvantages of your setup, a list of the required material, ... The presentation is both technical and commercial, where you convince the customer of your solution.
- Simulated environment within Packet Tracer
- Proof-of-concept with the currently available Cisco devices

On ** Github **:

- Tender book
- All background information that you have collected in order to get started with the assignment
- Physical and logical topology of the network infrastructure
- Packet Tracer files with the simulation of the network infrastructure
- A list of necessary materials, including prices
- Detailed installation procedures and scripts (directed to the team members)
- User's guide for your customer
- Test plans and test reports
