# Research

### Inferential statistic
In the inferential statistics we want to study an unknown popolation starting from a known sample.

In statistics by population (or statistical collective or aggregate ) we mean the set of elements that are the object of study, or the set of units (called statistical units ) on which the phenomenon studied occurs. These units all have at least one common characteristic, which is accurately defined in order to delimit their whole.

In Inferential statistics we have two levels of study:

+ Theorical: the level of the unknown and of what we want to determine informations about.
+ Empirical: the level of the known in which we find the empirical sample.

In the empirical level we can do observation and measures, compute the frequency and obtain an empirical distribution of a general attribute $X$.
The inference induction is the process of determine the probability starting from the frequence of an attribute $X$.

In the theoretical layer, for each attribute $X$ there's a theoretical distribution (that might be continous or descrete). The empirical counterpart of the theoretical distribution is called Sampling distribution:

Sampling distribution or finite-sample distribution is the probability distribution of a given random-sample-based statistic. If an arbitrarily large number of samples, each involving multiple observations (data points), were separately used in order to compute one value of a statistic (such as, for example, the sample mean or sample variance) for each sample, then the sampling distribution is the probability distribution of the values that the statistic takes on.

### Expected value and variance

Given a sequence of identical distributed and indipendent random variables $\{X_i\}$ for $i\in \mathbb{N}$, we can define the mean random variable called "sampling mean" as the following:

$$
\bar{X}=\frac{\sum_i X_i}{n}
$$

Let's compute the expected value and the variance of the sampling mean:

$$
E\[\bar{X}\]=E\[\frac{\sum_i X_i}{n}\]=\frac{1}{n}\sum_i E\[X_i\]=\frac{1}{n}nE\[X\]=E\[X\]
$$

$$
Var(\bar{X})=Var(\frac{\sum_i X_i}{n})=\frac{1}{n^2}Var(\sum_i X_i)=\frac{1}{n^2}nVar(X)=\frac{\sigma ^2}{n}
$$
