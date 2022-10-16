---

theme: jekyll-theme-hacker

title: Research

permalink: /Week3/research

---

# Research [^1]
> Illustrate the concepts of conditional, joint and marginal frequency using a simple bivariate distribution. Illustrate the concept of statistical indipendence and the resulting mathematical relationship between the above frequencies.

A **two-way frequency table** is a table that displays the frequencies for two categorical variables.

For example, the following two-way table shows the results of a survey that asked 100 people which sport they liked best: baseball, basketball, or football.

The rows display the gender of the respondent and the columns show which sport they chose:

|      | Baseball | Basketball  | Football | Total |
|------|----------|-------------|----------|-------|
| Male | 13 | 15| 20 | 48|
| Female | 23 | 16 | 13 | 52 |
| Total | 36 | 31 | 33 | 100 |

#### Conditional Relative Frequency
A **conditional relative frequency** compares a frequency count to the marginal total that represents the condition of interest. 

For example in the table above, let's take the condition of interest as the first row (Male units). The row conditional relative frequency of males responding "Football" as their sport of choise is $20/48$, or approximately $0.42$. 

This indicates that approximately 42% of males prefer "Football" as a sport.

#### Joint Relative Frequency
A **joint relative frequency** tells us the frequency of one variable relative to another variable. For istance in the table above, we could ask what is the joint relative frequency that a survey respondent is male, given that they prefer football as their favorite sport?

To answer this, we will only consider the column that contains football as the favorite sport. We’ll then take the number of males who prefer football and divide by the total number of respondents who preferred football.

This turns out to be $20/33 = 0.606 = 60.6$%
In other words, $60.6$% of all survey respondents who prefer football are male.

#### Marginal Relative Frequency

The **Marginal Relative Frequency** is the ratio between the frequency of a row total or column total to the total frequency of the data. It is commonly used to analyze general trends in one specific category of data. 

In the table above, the marginal frequencies can be found using the bottom or far-right "total" columns. To find the relative frequency of a category, divide the total for a specific category by the total number of participants in the study.

In our example table, let's compute the marginal relative frequency of participants that chose "Football" as their favourite sport: this turns out to be $33/100 = 0.33 = 33$%

### Statistical Indipendence
**Statistical independence** is a concept in probability theory. Two events $A$ and $B$ are statistical independent if and only if their joint probability can be factorized into their marginal probabilities, i.e., $P(A ∩ B) = P(A)P(B)$. If two events $A$ and $B$ are statistical independent, then the conditional probability equals the marginal probability: $P(A|B) = P(A)$ and $P(B|A) = P(B)$.

So according to the next table

if we define the joint frequency as $f_{ij}$, the marginal frequency as $f_{i\cdot}$ or $f_{\cdot j}$, and the conditional frequency as $f_{j|i}$, the following relations are true:

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
