# Git Bash工具配置GitHub

https://help.github.com/          需要这个配置

## 第一步需要安装一个gitbash

https://git-scm.com/downloads     官网需要翻墙不然没有速度

可以查找百度云资源

下载完安装，安装过程就是一直下一步



## 第二步 配置用户名

git config --global user.name "MrQuinPrime"      MrQuinPrime修改成你的github用户名

git config --global user.name     查看是否添加用户名



## 第三步 配置邮箱

git config --global user.email "1135623229@qq.com"     1135623229@qq.com修改成你的github邮箱

git config --global user.email     查看是否添加邮箱



## 第四步 配置ssh

ssh-keygen -t rsa -b 4096 -C "1135623229@qq.com"     1135623229@qq.com修改成你的github邮箱



## 记住这个路径

（/c/Users/ND01/.ssh/id_rsa）:



## ssh的存放路径 

C:\Users\ND01\.ssh

进入这个路径找到  id_rsa.pub

## **复制里面的内容**

回到github setting ssh and gpg keys 点击new ssh keys title 随便

## **key 就是刚刚复制的粘贴进来 add ssh key**



好了，这些配置就好了



## 接下来才是clone一份远程仓库的项目到本地

git clone https://github.com/MrQuinPrime/DataStructuresAndAlgorithm.git      后面的网址就是你的项目地址

如果有CHAME这个可以更改成我们自己的域名，然后记得解析就行

_posts 文件夹 都是文字 用markdown语法写的

## 进入仓库里面操作

cd DataStructuresAndAlgorithm    

## 查看状态

git status   

## 添加所有修改

git add .

状态变绿就行

git commit -m "2333"   这个233可以改成其他，相当于你修改做了什么，做个记号把！

## 推送

git push 

推送 第一次就会弹出这个用户名界面 第二次输入密码就可以推送了

每一次修改都有邮件提醒



最后说明一下，如果项目添加CNAME内容有域名，解析了，找不到域名就把none改成master branch

方法：项目 setting GitHub Pages     Source   即可