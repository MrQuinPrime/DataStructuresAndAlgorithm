# Linq_001_005



## 001

### 在数据集合：int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };中查询小于 5 的元素



## 002

### 在商品的数据集合中，查询库存数量为零的商品：

 

## 003  

### 在商品的数据集合中，查询 库存数量>0 并且单价>3.00的商品：     



## 004 

### 在客户的数据集合中，查询地区是 WA 的客户，然后再查询每个满足条件客户的所有的订单



## 005

### 对于数据集合：string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };查询集合元素的：字符长度小于其索引值 的元素。



# Linq_006_010

## 006

### 使用 select 从已经存在的数据集的数据表 Numbers 的元素中，生成一个比原来 +1 的新的数据集合源数据集合元素： 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 

## 007

### 使用 select 从数据集的产品数据表中，只提取产品名称，构建一个新的产品名称的集合

## 008

### 使用 select 从数据表 Numbers 的元素中，提取相应的整形数据，并将这些数据作为索引，从 string[] 中检索出相应的字符串，构建一个新的数据集合。Tables["Numbers"]的数据元素：5, 4, 1, 3, 9, 8, 6, 7, 2, 0变量 strings 的数据源："zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"

## 009

### 使用 select 从数据表 Words 构建全是大写、小写的新的数据集合

## 010

### 使用 select 从数据表 Numbers 和 Digits 中构建一个新的数据集合，集合的元素为：数字字符串：根据 Numbers 的元素作为索引，在 Digits 中抽取对应的值；是否是偶数：对选中的元素进行处理判断后赋值。
Tables["Numbers"]的元素：5, 4, 1, 3, 9, 8, 6, 7, 2, 0
Tables["Digits"]的元素："zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" 

# Linq_011_019

## 011

### 使用 select 从商品数据表 Products 中抽取部分属性（例如：ProductName，Category，UnitPrice），构建一个新的数据集合，其中还可以将 Product 属性的名称根据需要重新命名，例如将 UnitPrice 更改为 Price。

## 012

### 使用 select 索引从从数据表 Numbers 中选择出数值和它的索引位置，并且判断两者是否，构建一个新的元素集合。Tables["Numbers"]的元素：5, 4, 1, 3, 9, 8, 6, 7, 2, 0