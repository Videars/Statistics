---

theme: jekyll-theme-hacker

title: Research

permalink: /Week3/research

---

# Research [^1]
> Illustrate the concepts of conditional, joint and marginal frequency using  a simple bivariate distribution. Illustrate the concept of statistical indipendence and the resulting mathematical relationship between the above frequencies.


# App
> Create a distribution from the data obtained by the program wireshark by reading the csv file generated.

We start by sniffing the WiFi traffic using the program Wireshark. We will obtain a list of all the packets sent and received by the target machine and thanks to a wireshark feature we can export this data as a csv file. Let's create a windows form app with a data table and a rich text box tools.

<img width="550" alt="1" src="https://user-images.githubusercontent.com/105921751/195995417-b5ae8d7f-23c4-4f9e-9039-e3fae4a708c9.png">

Clicking the print button, a CSV parser will start reading the wireshark file and creating a table with all the packets and their respective informations: ID, Timestamp, Soure, Destination, Protocol, Length and Information. 

<img width="550" alt="2" src="https://user-images.githubusercontent.com/105921751/195995419-e07aaae7-f4e1-410a-b0c9-1e91c7d5968e.png">

Once the parsing is done, we can click the analyze button. The program will go through all the packets inside the table, save the different protocols that it is able to find and count the occurrencies of every protocol type. At the end of the process the results will be printed out in the rich text box.

<img width="550" alt="3" src="https://user-images.githubusercontent.com/105921751/195995421-49c718c9-6b1d-45b4-9f9d-c10cbf388b75.png">

# Research on App
> Survey on OnLine algorithms. In particular Knuth recursion for the computation of the arithmetic mean (average). 



[^1]: Class Notes
