---

theme: jekyll-theme-hacker

title: Research

permalink: /Week5/research

---

# Research

> Explain all possible derivation of the arithmetic mean and in general of the other common types of average: harmonic, geometric and power mean. Illustrate the difference between "mathematical convergence" and "convergence" in probability.

### Mean

There are several statistical quantities called means, e.g. arithmetic mean, harmonic mean, geometric mean and power mean. Let's define them all starting from the Power mean [^1].

If $p$ is a non-zero real number, and $x_{1},\dots ,x_{n}$ are positive real numbers, then the generalized mean or power mean with exponent $p$ of these positive real numbers is:

$$
M_{p}(x_{1},\dots ,x_{n})=\left({\frac {1}{n}}\sum_{i=1}^{n}x_{i}^{p}\right)^{1/p}.
$$

A few particular values of $p$ yield special cases with their own names:

Harmonic mean (for $p=-1$):

$$
M_{-1}(x_{1},\dots ,x_{n})={\frac{n}{\frac{1}{x_{1}}+\dots +\frac {1}{x_{n}}}}
$$

Geometric mean (for $p=0$):

$$
M_0(x_1,\dots,x_n) = \lim_{p\to0} M_p(x_1,\dots,x_n) = \sqrt[n]{x_1\cdot\dots\cdot x_n}
$$

Arithmetic mean (for $p=1$):

$$
M_1(x_1,\dots,x_n) = \frac{x_1 + \dots + x_n}{n}
$$

The arithmetic mean [^2] has several properties that make it useful, especially as a measure of central tendency. These include:

+ If numbers $x_{1},\dotsc ,x_{n}$ have mean ${\bar {x}}$, then $(x_{1}-{\bar {x}})+\dotsb +(x_{n}-{\bar {x}})=0$. Since $x_{i}-{\bar {x}}$ is the distance from a given number to the mean, one way to interpret this property is as saying that the numbers to the left of the mean are balanced by the numbers to the right of the mean. The mean is the only single number for which the residuals (deviations from the estimate) sum to zero.
+ If it is required to use a single number as a "typical" value for a set of known numbers $x_{1},\dotsc ,x_{n}$, then the arithmetic mean of the numbers does this best, in the sense of minimizing the sum of squared deviations from the typical value: the sum of $(x_{i}-{\bar {x}})^{2}$.

### Convergence

#### Limit of a sequence (math limit) [^3]
Given $\\{x_n\\}$ a sequence of real numbers, we say that $\lim_{n\to\infty}x_n=a$ with $a\in \mathbb{R}$ if for each $\epsilon >0$ arbitrary small, $\exists n_0 \in \mathbb{N}$ so that $\|x_n-a\|<\epsilon$ for each $n>n_0$.

<img width="500" alt="limit" src="https://user-images.githubusercontent.com/105921751/198825805-1aef0777-3108-442c-a6cd-c85e73cf68e1.jpg">

#### Convergence in Probability [^4]

The concept of convergence in probability is based on the following intuition: two random variables are "close to each other" if there is a high probability that their difference is very small.

Let $\\{X_n\\}$ be a sequence of random variables defined on a sample space $\Omega$.

Take a random variable $X$ and a strictly positive number $\epsilon$.

Suppose that we consider $X_n$ far from $X$ when

$$
\|X_n-X\|>\epsilon
$$

Then, the probability

$$
P(\|X_n-X\|>\epsilon)
$$

is the probability that $X_n$ is far from $X$.

The idea is that: if $\\{X_n\\}$ converges to $X$, the probability that $X_n$ and $X$ are far from each other should become smaller and smaller as $n$ increases.

In other words, we should have

$$
\lim_{n\to\infty}P(\|X_n-X\|>\epsilon)=0
$$

Note that now $P(\|X_n-X\|>\epsilon)$ is a sequence of real numbers. Therefore, the limit in the above equation is the usual limit of a sequence of real numbers.

We would like to be very restrictive on our criterion for deciding whether $X_n$ is far from $X$. As a consequence, the condition should be satisfied for any, arbitrarily small, $\epsilon$.

The variable $X$ is called the probability limit of the sequence and convergence is indicated by $X_n\to_{p}X$


[^1]: https://en.wikipedia.org/wiki/Generalized_mean
[^2]: https://en.wikipedia.org/wiki/Arithmetic_mean
[^3]: https://en.wikipedia.org/wiki/Limit_(mathematics)
[^4]: https://www.statlect.com/asymptotic-theory/convergence-in-probability
