# Csharp_practice

--- SQL Server---
https://hackmd.io/0e0kY-iFRKSJK7rAh_2Z8A?both

---11/29學習回顧---
1. 物件導向和程式、編譯順序、nameSpace
2. 常用視窗功能:classView, ObjectBrowser,文件大綱
3. new新物件 範例:form call form功能
4. 除錯燈泡與沒引入的誤進到classView搜索
5. 建立方法(定義function)
其他:基礎IT第五章

---11/30學習回顧---
1. add returnMethod
2. 封裝
3. partial class
4. change property
5. delegate委派 & 註冊事件


---12/1學習回顧---
1. 變數、基本控制項、屬性方法
2. 前置後置遞增運算
TODO:decimal的blog
3. 區域變數vs類別變數
4. Instance vs static + 執行個體變數
5. callByRef vs CallByVal

--12/12學習回顧--
1. enum
2. struct
3. 傳Ref
4. function不一定會傳入的參數用params
5. 屬性與建構子
        public static hw_E1_guessMain formInstance;
        public Label labelInstance;
        public hw_E1_guessMain()
        {
            InitializeComponent();
            formInstance = this;
            labelInstance = labelShowMsg;
        }
hw_E1_guessMain.formInstance.labelInstance.Text = returnUserGuess();


待辦事項:
C#筆記整理變數傳遞、建構子、類別屬性建立、變數權限
老師回答的問題整理筆記

問題整理:
1. HW1無法調整按鈕新增三角形的圖案
2. Main的表單會切到圖片，icon也是
3. 點到元件叫出空的參考，可以自動整理刪掉嗎?
4. 執行到一半看屬性值 例如size
5. TODO兩個表單的相對位置不會設定hw1與main

6. struct的屬性等同於類別的欄位?


