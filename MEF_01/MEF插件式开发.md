<font face=Times New Roman>
### 插件式程序开发(MEF)总体上主要有三大部分组成，这三大部分都位于同一个解决方案下面。

#### 1、主程序
- 主程序是一个`project`，它主要用来作为整个程序的启动入口点。
- 主程序可以被编译成可执行文件，来将其它`project`编译的`.dll`文件加载进来。
- 主程序一般为`WPF`程序。


#### 2、接口程序
- 该程序为类库项目(即`Class Library`)
- 主要用来规范提供接口，其编译的结果为`.dll`文件


#### 3、插件程序
- 插件程序一般为`WPF User Control Library`