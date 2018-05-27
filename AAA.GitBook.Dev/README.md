#
制作编辑指导

## 1. 工具支持

* 安装NodeJs，参考地址：https://www.w3cschool.cn/nodejs/
* 安装Visual Studio Code，下载地址：https://code.visualstudio.com/

## 2、MarkDown语法学习

* 官方文档： http://gitbook.site/syntax/markdown.html
* 其他文档：https://www.w3cschool.cn/markdownyfsm/markdownyfsm-odm6256r.html

## 3、GitBook使用说明

* 官方文档：http://gitbook.site/

* 其他文档：http://gitbook.zhangjikai.com/

## 4. 编辑

* 创建目录：Platform
* 创建 SUMMARY.md MarkDown文件
* 编辑目录
* 打开cmd，cd至Platform目录，执行指令GitBook Init
* 使用Visual Studio Code 打开Platform文件夹，打开对应的MarkDown文件进行编辑
* 添加Syles文件夹，添加Website.css，进行相关样式编辑
* 添加Book.json文件，进行相关配置，如下：
``` json
{
    "title":"平台",
    "author":"caizz",
    "description":"平台",
    "language":"zh-hans",
    "plugins": ["prism", "-highlight"]
}
```

## 5. 预览

* 打开命令提示符cmd（管理员），cd至Platform。
* 若book.json配置了新的插件，请执行gitbook install指令，它将自动为您安装好插件。
* 输入指令 gitbook serve，它将编译输出在Platform文件目录的_book目录下。
* 打开浏览器浏览。
* 若需要导航等效果，可以在Visual Studio Code中，将$(SolutionDir)Platform\_book\Styles\WebSite.css中的屏蔽样式清除，再刷新浏览器http://localhost:4000

## 6. 发布

>git init

>git add *.*

>git commit -m "初始化"

打开GitBook客户端，点击Publish

## 7. 注意事项

使用了prism插件后，代码才有高亮，而且语言要书写对，比如：C#应该写成csharp


