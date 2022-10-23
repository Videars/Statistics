---

theme: jekyll-theme-hacker

title: Research

permalink: /Week4/research

---

# Research [^1]
> Paralles between the properties of the relative frequency and the axioms for probability measure. Discuss some concrete examples of measure space. Illustrate how measure theory provides the mathematical foundation for probability.

Relative frequency has some basic properties. Following the illustration below, we can enumerate them as:

<img width="500" alt="venn" src="https://user-images.githubusercontent.com/105921751/197346577-2b79d58f-6a69-4a19-aa29-946fbbc6621e.jpg">

+ $0\leq f_A \leq 1$
+ $f_{A \cup B} = f_A + f_B $ in case $A$ and $B$ are disjoint
+ $f_{A \cup B} = f_A + f_B - f_{A \cap B}$
+ $f( \emptyset ) = 0$
+ $f(P) = 1$

Now why are they useful? The concepts of Probability and Frequency are actually very close (so that we can define one of them through the other) and that's why they have some properties in common. Let's see the definition of probability to spot the similarities between the two. 

Probability is the branch of mathematics concerning numerical descriptions of how likely an event is to occur, or how likely it is that a proposition is true. The probability of an event is a number between 0 and 1, where, roughly speaking, 0 indicates impossibility of the event and 1 indicates certainty. The higher the probability of an event, the more likely it is that the event will occur.

These concepts have been given an axiomatic mathematical formalization in probability theory, which is used widely in areas of study such as statistics, mathematics, science, finance, gambling, artificial intelligence, machine learning, computer science, game theory, and philosophy to, for example, draw inferences about the expected frequency of events.

### Golmogorov Axioms

The assumptions as to setting up the axioms can be summarised as follows: Let $(\Omega, F, P)$ be a measure space with $P(E)$ being the probability of some event $E$, and $P(\Omega )=1$. Then $(\Omega, F, P)$ is a probability space, with sample space $\Omega$, event space $F$ and probability measure $P$.

#### First axiom

The probability of an event is a non-negative real number:

$P(E)\in \mathbb {R} , P(E)\geq 0\qquad \forall E\in F$ where $F$ is the event space. It follows that $P(E)$ is always finite, in contrast with more general measure theory. Theories which assign negative probability relax the first axiom.

#### Second axiom

This is the assumption of unit measure: that the probability that at least one of the elementary events in the entire sample space will occur is $1$

$P(\Omega )=1$

#### Third axiom
This is the assumption of σ-additivity:

Any countable sequence of disjoint sets (synonymous with mutually exclusive events) $E_{1},E_{2},\ldots$ satisfies $P\left(\bigcup_{i=1}^{\infty }E_{i}\right)=\sum_{i=1}^{\infty}P(E_{i})$.

### Probability Space examples

$(\Omega , \epsilon, p)$ in case of **Coin Toss**:

$\Omega = \\{ T, C \\} $

$\epsilon = \\{ \Omega, \emptyset , T, C, \bar{T}, \bar{C}, T \cup C, T \cap C \\} $

$(\Omega , \epsilon, p)$ in case of **Card extraction**:

if we have a standard deck with 52 cards and 4 seeds like so (H=hearts, D=diamonds, C=clubs, S=spades) the we will have:

$\Omega = \\{ AH,2H,...,JH,QH,KH, AD,2D,...,KD, AC,...,KC, AS,...,KS \\} $

$\epsilon = \\{ \Omega, \emptyset , AH, 2H, ..., \bar{AH}, \bar{2H}, AH \cup 2H, ..., AH \cap 2H, ... \\} $

### Measure theory [^2]

The probability theory (and the Golmogorov's axioms) has his foundation on the measure theory.

Let $X$ be a set and $\Sigma$  a $\sigma$ -algebra over $X$. A set function $\mu$  from $\Sigma$  to the extended real number line is called a measure if it satisfies the following properties:

**Non-negativity**: For all $E$ in $\Sigma$ , we have $\mu (E)\geq 0$.

**Null empty set**: $\mu (\varnothing )=0$.

**Countable additivity** (or $\sigma$ -additivity): For all countable collections $\\{ E_{k}\\}$ of pairwise disjoint sets in $\Sigma$,

$$\mu \left(\bigcup_{k=1}^{\infty }E_{k}\right)=\sum_{k=1}^{\infty }\mu (E_{k}).$$

If at least one set $E$ has finite measure, then the requirement that $\mu (\varnothing )=0$ is met automatically. Indeed, by countable additivity,

$$\mu (E)=\mu (E\cup \varnothing )=\mu (E)+\mu (\varnothing ),$$

and therefore $\mu (\varnothing )=0$.

The pair $(X,\Sigma )$ is called a measurable space, and the members of $\Sigma$ are called measurable sets.

A triple $(X,\Sigma ,\mu )$ is called a measure space. A probability measure is a measure with total measure one – that is, $\mu (X)=1$. A probability space is a measure space with a probability measure.

# Application

> Simulate a sequence of coin tosses (0 for success, 1 for failure) where the probability of success is a parameter and draw a dynamic chart of the Absolute, Relative and Normalized frequencies.

Let's start with simulating the coin tosses with the random tool. For every toss, we save the result in a list and at the end of the simulation we will print the lists obtained as a line chart using the bitmap tool. Here is a video of how the app works.

<iframe width="750" height="500" src="https://user-images.githubusercontent.com/105921751/197398964-1201eeb7-5b74-4559-8e05-363421425eb4.mp4" frameborder="0" allowfullscreen></iframe>


[^1]: Class Notes
[^2]: https://en.wikipedia.org/wiki/Measure_(mathematics)
