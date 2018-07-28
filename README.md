# reduce.net
reduce api in .net collection. It is equivant API [reduce](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/reduce) in javascript.

Sample:

```csharp
  var numbers = new List<int> { 1, 2, 3, 4 };
  var sum = numbers.Reduce( (acc,cur) => { return acc + cur; }, 0);
  Console.WriteLine(sum);
```
