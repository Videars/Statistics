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

This turns out to be $20/33 = 0.606 = 60.6$%.
In other words, $60.6$% of all survey respondents who prefer football are male.

#### Marginal Relative Frequency

The **Marginal Relative Frequency** is the ratio between the frequency of a row total or column total to the total frequency of the data. It is commonly used to analyze general trends in one specific category of data. 

In the table above, the marginal frequencies can be found using the bottom or far-right "total" columns. To find the relative frequency of a category, divide the total for a specific category by the total number of participants in the study.

In our example table, let's compute the marginal relative frequency of participants that chose "Football" as their favourite sport: this turns out to be $33/100 = 0.33 = 33$%

### Statistical Indipendence
**Statistical independence** is a concept in probability theory. Two events $A$ and $B$ are statistical independent if and only if their joint probability can be factorized into their marginal probabilities, i.e., $P(A ∩ B) = P(A)P(B)$. If two events $A$ and $B$ are statistical independent, then the conditional probability equals the marginal probability: $P(A\mid B) = P(A)$ and $P(B\mid A) = P(B)$.

So according to the next table:

<img width="500" alt="4" src="https://user-images.githubusercontent.com/105921751/196037694-0aa1430d-bd7e-4e7d-b209-abb55bf4f257.jpg">

if we define the joint frequency as $f_{ij}$, the marginal frequency as $f_{i\cdot}$ or $f_{\cdot j}$, and the conditional frequency as $f_{j\mid i}$, the following relations are true:

$$
f_{ij}=freq(X=X_i \wedge Y=Y_j)=\frac{n_{ij}}{n}
$$

$$
f_{i\cdot}=\sum_{j=1}^{c}\frac{n_{ij}}{n}=\frac{n_{i\cdot}}{n}
$$

$$
f_{j\mid i}=\frac{f_{ij}}{f_{i\cdot}}=\frac{freq(X=X_i \wedge Y=Y_j)}{freq(X=X_i)}=\frac{n_{ij}}{n_{i\cdot}}
$$

In conclusion the random variables $X$ and $Y$ are indipendent if $fr(X\mid Y)=fr(X)$ or if $fr(X\wedge Y)=fr(X)\cdot fr(Y)$.

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

An **online algorithm**[^2] is one that can process its input piece-by-piece in a serial fashion, i.e., in the order that the input is fed to the algorithm, without having the entire input available from the start.

Because it does not know the whole input, an online algorithm is forced to make decisions that may later turn out not to be optimal, and the study of online algorithms has focused on the quality of decision-making that is possible in this setting. Competitive analysis formalizes this idea by comparing the relative performance of an online and offline algorithm for the same problem instance. Specifically, the competitive ratio of an algorithm, is defined as the worst-case ratio of its cost divided by the optimal cost, over all possible inputs. The competitive ratio of an online problem is the best competitive ratio achieved by an online algorithm. Intuitively, the competitive ratio of an algorithm gives a measure on the quality of solutions produced by this algorithm, while the competitive ratio of a problem shows the importance of knowing the future for this problem.

The concept behind the mean is simple. The purpose of an average value is to find a single number to represent the typical value of an entire list of numbers of every kind. The quick and dirty tip to calculate the mean value of a sample is first adding up all the numbers in the sample and then dividing this total by the number of sample. This method might be inaccurate and not efficient to compute mean for a stream of data, so we can use an Online algorithm instead.

### Knuth’s algorithm [^3]
This algorithm computes the mean iteratively. This means that at each step, the value for the mean computed with the first $n-1$ inputs it’s updated when the input $x_n$ is received. The formula used in this algorithm is the following:

$$
\overline x_n=\frac{(n-1)\overline x_{n-1} +x_n}{n}=\overline x_{n-1}+\frac{x_n-\overline x_{n-1}}{n}
$$

The corresponding algorithm is the following:

    def online_mean(data):
        n = 0
        mean = M2 = 0.0

        for x in data:
            n += 1
            delta = x - mean
            mean += delta/n
            delta2 = x - mean
            M2 += delta*delta2

        if n < 2:
            return float('nan')
        else:
            return M2 / (n - 1)


[^1]: Class Notes
[^2]: https://en.wikipedia.org/wiki/Online_algorithm
[^3]: https://mlblogblog.wordpress.com/2017/11/22/r2-the-best-algorithm-to-compute-the-online-mean/
