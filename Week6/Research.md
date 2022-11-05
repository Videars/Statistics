---

theme: jekyll-theme-hacker

title: Research

permalink: /Week6/research

---

# Research

### Inferential statistic
In the inferential statistics we want to study an unknown popolation starting from a known sample.

In statistics by population [^1] (or statistical collective or aggregate ) we mean the set of elements that are the object of study, or the set of statistical units on which the phenomenon studied occurs. These units all have at least one common characteristic, which is accurately defined in order to delimit their whole.

In Inferential statistics we have two levels of study:

+ Theorical: the level of the unknown population of which we want to gather some information.
+ Empirical: the level of the known in which we find the empirical sample (subset of the population).

In the empirical level we can do observations and measures, compute the frequency and obtain an empirical distribution of a general attribute $X$.
The inference induction is the process of determine the probability starting from the frequence of an attribute $X$.

In the theoretical layer, for each attribute $X$ there's a theoretical distribution (that might be continous or descrete). The empirical counterpart of the theoretical distribution is called Sampling distribution:

Sampling distribution [^2] or finite-sample distribution is the probability distribution of a given random-sample-based statistic. If an arbitrarily large number of samples, each involving multiple observations (data points), were separately used in order to compute one value of a statistic (such as, for example, the sample mean or sample variance) for each sample, then the sampling distribution is the probability distribution of the values that the statistic takes on.

### Expected value and variance of the sampling mean

Given a sequence of identical distributed and indipendent random variables $\{X_i\}$ for $i\in \mathbb{N}$, we can define the mean random variable called "sample mean" as the following:

$$
\bar{X}=\frac{\sum_i X_i}{n}
$$

So the sample mean $\bar{X}$ from a group of observations is an estimate of the population mean.

Let's compute the expected value and the variance of the sample mean [^3]:

$$
E(\bar{X})=E(\frac{\sum_iX_i}{n})=\frac{1}{n}\sum_iE(X_i)=\frac{1}{n}nE(X)=E(X)
$$

$$
Var(\bar{X})=Var(\frac{\sum_i X_i}{n})=\frac{1}{n^2}Var(\sum_i X_i)=\frac{1}{n^2}nVar(X)=\frac{\sigma ^2}{n}
$$

We can see that the expected value of the sampling mean is equal to the mean value computed on the population (as we were expecting intuitivelly) and that the variance of the sampling mean is equal to the standard deviation over $n$ (that tends to zero for large $n$).

### Expected value and variance of the sampling variance

Starting from the same sequence of random variables we can define the sample variance too. The sample variance, $S_2$, is used to calculate how varied a sample is.

$$
S_2=\frac{1}{n}\sum_{i=1}^n(X_i-\bar{X})^2
$$

Let's compute the expected value [^4] and the variance [^5] of the sample variance:

$$
E(S_2)=E(\frac{1}{n}\sum_{i=1}^n(X_i-\bar{X})^2)=\frac{n-1}{n}\sigma ^2
$$

$$
Var(S_2)=Var(\frac{1}{n}\sum_{i=1}^n(X_i-\bar{X})^2)=\frac{\mu_4}{n}-\frac{\sigma ^4(n-3)}{n(n-1)}
$$

where $\mu_4=E((X-\bar{X})^4)$ is the fourth central moment of $X$.


[^1]: https://en.wikipedia.org/wiki/Statistical_population
[^2]: https://en.wikipedia.org/wiki/Sampling_distribution
[^3]: http://www.stat.yale.edu/Courses/1997-98/101/sampmn.htm
[^4]: https://en.wikipedia.org/wiki/Variance
[^5]: https://math.stackexchange.com/questions/72975/variance-of-sample-variance
