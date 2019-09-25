function optionalPow(a, b) {

  if (confirm('Are you sure you want to compute the result of raising the first argument to the power determined by the second argument?')) {
    return Math.pow(a, b)
  } else {
    return Math.pow(b, a)
  }


}