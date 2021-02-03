# Null.ConsoleEx

提供关于 Console 类的一些拓展内容. 例如一些方法(Method)

### 命名空间:

1. Null.ConsoleEx: 包含两个类: ConsoleEx(ConsoleExtension) 与 ConsoleExS(ConsoleExtensionSafe)

   两个类的成员完全一致, 但是 ConsoleExS 添加了一些安全检查, 例如 null 检查, 所以, 如果为了速度着想, 请使用 ConsoleEx.

### 方法:

1. ConsoleEx.IsWideDisplayChar(char c) 判断字符在控制台中显示的长度是否大于1
2. ConsoleEx.GetCharDisplayLength(char c) 获取字符在控制台中的显示长度, 对于 \t, 返回结果是8, \n及\r, 返回结果是0
3. ConsoleEx.GetStringDisplayLength(string str) 获取字符串在控制台中的显示长度
