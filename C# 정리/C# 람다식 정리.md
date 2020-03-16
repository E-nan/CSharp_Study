## C# 람다식
C# 3.0부터 지원하는 => 연산자는 C#에서 람다식(Lambda Expression)을 표현할 때 사용한다.
람다식은 무명 메소드와 비슷하게 무명 함수(anonymous function)을 표현하는데 사용된다. 람다식은 예제와 같이 입력 파라미터 (n개)를 => 연산자 왼쪽에, 실행 문장들을 => 연산자 오른쪽에 둔다.
```
람다식 문법 : (입력 파라미터) => {실행문장 블럭}
```
예를 들어 하나의 문자열을 받아 메시지 박스를 띄운다면 다음과 같이 간단하게 쓸 수 있다.
```
str => {MessageBox.Show(str);}
```

- 입력 파라미터는 하나도 없는경우부터 여러개 있는 경우도 있다.
- 일반적으로 데이터 타입은 컴파일러가 알아서 찾아주지만, 모호한 경우 명시해줄수도 있다.
---
#### 예제
- 파라미터 에 따라 다른 예제

```
// 입력 파라미터가 없는 경우
() => Write("No");

// 입력 파라미터가 1~2개 있는 경우
(p) => Write(p);
(s, e) => { Write(s); Write(e); }

// 입력 파라미터 타입을 명시하는 경우
(string s, int i) => Write(s, i);
```
- 메소드명(함수)를 간략하게 표시하는 에제

```
this.button1.Click += new System.EventHandler(button1_Click);

private void button1_Click(object sender, EventArgs e)
{
   ((Button)sender).BackColor = Color.Red;
}
```
위 예제는 button1의 클릭 이벤트에 button1_Click 이벤트 핸들러 메소드를 추가하고 있는데, button1_Click 메소드는 클래스 어딘가에 정의되어 있어야 한다.

```
this.button1.Click += button1_Click;

private void button1_Click(object sender, EventArgs e)
{
   ((Button)sender).BackColor = Color.Red;
}
```
간단하게 메소드명만 사용하여 위처럼 줄일수 있다.
```
this.button1.Click += delegate(object sender, EventArgs e)
{
   ((Button)sender).BackColor = Color.Red;
};
```
이를 좀더 간단하게 하려면 위 코드처럼 무명메소드를 써서 표현할 수 있다.

```
this.button1.Click += (sender, e) => ((Button)sender).BackColor = Color.Red;
```
여기서 더 간단하게 람다식을 이용하여 위처럼 바꿀 수 있다.
예제처럼 실행블럭이 한 문장일때는 {} 괄호를 생략할 수 있다.