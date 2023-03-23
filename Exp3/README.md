# Exp3 统计用户输入的字符串中各字符的出现次数

## C#中`Convert`和`Parse()`比较分析

`Convert`将一个基本数据类型转换为另一个基本数据类型。

继承关系 `Object` → `Convert`，表明其从根本上是对继承自`Object`的类型的转换，对于实际的转换过程，一般会调用实际类型的转换方法。

例如`Convert.ToInt32()`中通过调用`Int32.Parse()`来实现。

```csharp
public static int ToInt32(String value) 
{
    if (value == null)
        return 0;
    return Int32.Parse(value, CultureInfo.CurrentCulture);
}
```

实际具体情况具体分析。


