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

Objectivists assign numbers to describe some objective or physical state of affairs. The most popular version of objective probability is frequentist probability, which claims that the probability of a random event denotes the relative frequency of occurrence of an experiment's outcome when the experiment is repeated indefinitely. This interpretation considers probability to be the relative frequency "in the long run" of outcomes. A modification of this is propensity probability, which interprets probability as the tendency of some experiment to yield a certain outcome, even if it is performed only once.
Subjectivists assign numbers per subjective probability, that is, as a degree of belief. The degree of belief has been interpreted as "the price at which you would buy or sell a bet that pays 1 unit of utility if E, 0 if not E", although that interpretation is not universally agreed upon. The most popular version of subjective probability is Bayesian probability, which includes expert knowledge as well as experimental data to produce probabilities. The expert knowledge is represented by some (subjective) prior probability distribution. These data are incorporated in a likelihood function. The product of the prior and the likelihood, when normalized, results in a posterior probability distribution that incorporates all the information known to date. By Aumann's agreement theorem, Bayesian agents whose prior beliefs are similar will end up with similar posterior beliefs. However, sufficiently different priors can lead to different conclusions, regardless of how much information the agents share.

#### Frequentist definition

n the frequentist interpretation, probabilities are discussed only when dealing with well-defined random experiments. The set of all possible outcomes of a random experiment is called the sample space of the experiment. An event is defined as a particular subset of the sample space to be considered. For any given event, only one of two possibilities may hold: it occurs or it does not. The relative frequency of occurrence of an event, observed in a number of repetitions of the experiment, is a measure of the probability of that event. This is the core conception of probability in the frequentist interpretation.

A claim of the frequentist approach is that, as the number of trials increases, the change in the relative frequency will diminish. Hence, one can view a probability as the limiting value of the corresponding relative frequencies.

#### Propensity definition

The propensity theory of probability is a probability interpretation in which the probability is thought of as a physical propensity, disposition, or tendency of a given type of situation to yield an outcome of a certain kind, or to yield a long-run relative frequency of such an outcome.

Propensities are not relative frequencies, but purported causes of the observed stable relative frequencies. Propensities are invoked to explain why repeating a certain kind of experiment will generate a given outcome type at a persistent rate. A central aspect of this explanation is the law of large numbers. This law, which is a consequence of the axioms of probability, says that if (for example) a coin is tossed repeatedly many times, in such a way that its probability of landing heads is the same on each toss, and the outcomes are probabilistically independent, then the relative frequency of heads will (with high probability) be close to the probability of heads on each single toss. This law suggests that stable long-run frequencies are a manifestation of invariant single-case probabilities. Frequentists are unable to take this approach, since relative frequencies do not exist for single tosses of a coin, but only for large ensembles or collectives. These single-case probabilities are known as propensities or chances. Hence, it can be thought of as "meta-probability".

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

Any countable sequence of disjoint sets (synonymous with mutually exclusive events) $E_{1},E_{2},\ldots$ satisfies $P\left(\bigcup _{i=1}^{\infty }E_{i}\right)=\sum _{i=1}^{\infty }P(E_{i})$.
