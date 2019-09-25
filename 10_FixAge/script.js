function fixAge(ages) {
  var fixAges = ages.filter(x => x >= 18 && x <= 60);

  if (fixAges.length > 0) {
    return fixAges.join(",");
  }

}