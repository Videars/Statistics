---

theme: jekyll-theme-hacker

title: Research

permalink: /Week4/research

---

# Research [^1]
> Formal properties of relative frequencies. Definition of probability.

Relative frequency has some basic properties:

+ $0\leq f_A \leq 1$
+ $f_{A \cup B} = f_A + f_B $ in case $A$ and $B$ are disjoint
+ $f_{A \cup B} = f_A + f_B - f_{A \cap B}$
+ f( \0 ) = 0
+ f(P) = 1

Why is it useful? We can define probability through the frequency.

Probability is the branch of mathematics concerning numerical descriptions of how likely an event is to occur, or how likely it is that a proposition is true. The probability of an event is a number between 0 and 1, where, roughly speaking, 0 indicates impossibility of the event and 1 indicates certainty. The higher the probability of an event, the more likely it is that the event will occur. A simple example is the tossing of a fair (unbiased) coin. Since the coin is fair, the two outcomes ("heads" and "tails") are both equally probable; the probability of "heads" equals the probability of "tails"; and since no other outcomes are possible, the probability of either "heads" or "tails" is $1/2$ (which could also be written as $0.5$ or $50$%).

These concepts have been given an axiomatic mathematical formalization in probability theory, which is used widely in areas of study such as statistics, mathematics, science, finance, gambling, artificial intelligence, machine learning, computer science, game theory, and philosophy to, for example, draw inferences about the expected frequency of events. Probability theory is also used to describe the underlying mechanics and regularities of complex systems.

When dealing with experiments that are random and well-defined in a purely theoretical setting (like tossing a coin), probabilities can be numerically described by the number of desired outcomes, divided by the total number of all outcomes. For example, tossing a coin twice will yield "head-head", "head-tail", "tail-head", and "tail-tail" outcomes. The probability of getting an outcome of "head-head" is 1 out of 4 outcomes, or, in numerical terms, $1/4$, $0.25$ or $25$%. However, when it comes to practical application, there are two major competing categories of probability interpretations, whose adherents hold different views about the fundamental nature of probability:

### Golmogorov Axioms

The assumptions as to setting up the axioms can be summarised as follows: Let $(\Omega, F, P)$ be a measure space with $P(E)$ being the probability of some event $E$, and $P(\Omega )=1$. Then $(\Omega, F, P)$ is a probability space, with sample space $\Omega$ , event space $F$ and probability measure $P$.

#### First axiom

The probability of an event is a non-negative real number:

$P(E)\in \mathbb {R} ,P(E)\geq 0\qquad \forall E\in F$ where $F$ is the event space. It follows that $P(E)$ is always finite, in contrast with more general measure theory. Theories which assign negative probability relax the first axiom.

#### Second axiom
This is the assumption of unit measure: that the probability that at least one of the elementary events in the entire sample space will occur is $1$

$P(\Omega )=1$

#### Third axiom
This is the assumption of σ-additivity:

Any countable sequence of disjoint sets (synonymous with mutually exclusive events) $E_{1},E_{2},\ldots$ satisfies $P\left(\bigcup_{i=1}^{\infty }E_{i}\right)=\sum_{i=1}^{\infty}P(E_{i})$.

### Probability Space examples

$(\Omega , \epsilon, p)$ in case of ** COIN TOSS**:

$\Omega = \{ T, C \} $

$\epsilon = \{ \Omega, \0, T, C, \bar{T}, \bar{C}, T \cup C, T \cap C \} $

