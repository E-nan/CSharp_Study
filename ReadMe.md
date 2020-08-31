# C# 정리
- c#을 공부하면서 메모해 두는 ReadMe 파일.
***
### 참고 사이트
- 강의사이트
  - https://www.inflearn.com/ => 인프런
  - https://www.udemy.com/ko/ => 유데미
  
***
### Convension
#### 표기법
- 파스칼 케이스 (Pascal Case)
  - 각 단어의 첫문자를 대문자로 표기한다.
  - 클래스 및 메서드 네이밍에 사용한다. (MS 권장)
  - ex) PascalCaseStudy
  
- 카멜 케이스 (Camel Case)
  - 각 단어의 첫문자를 대문자로 표기하고 붙여쓰며, 맨처음 문자는 소문자로 표기한다.
  - 변수 및 파라미터 네이밍에 사용한다. (MS 권장)
  - ex) camelCaseStudy
  
- 스네이크 케이스 (Snake Case)
  - 각 단어를 언더바(밑줄)로 구분한다.
  - ex) snake_case_study
#### 네이밍
- 인터페이스 네이밍
  - 인터페이스에는 접두사 I 가 포함된 파스칼 케이스를 사용한다.
  - ex) IPascal
  
- 변수명 네이밍
  - 변수명에 충분한 의미를 담아야 하며, 약어를 사용하지 않는다.
  - ex) myNm (X), myName(O)
  
- 전역변수 네이밍
  - 전역변수 앞에는 언더바(밑줄)을 앞에 붙인다. 지역변수에는 사용하지 않는다.
  - ex) _glovalName

***
### Visual Studio 2019
- 코드 좌측 몇번째 줄인지 나타내는 숫자 오른쪽에 생성되는 초록색/노란색 부분은 각각 수정된 상태, 저장된 상태를 뜻한다. 

- 단축키
  - F1                  => 객체나 메서드를 클릭하고 F1을 누르면 MSDN 오픈
  - Ctrl + Shift + A    => 새 항목 추가
  - Ctrl + K, Ctrl + D  => 자동 정렬
  - Ctrl + K, Ctrl + C  => 주석
  - Ctrl + K, Ctrl + U  => 해제
  - Ctrl + R, Ctrl + R  => 변수명, 메서드명 등등.. 식별자 리팩토링
  - Ctrl + Shift + U    => 커서 앞의 한글자, 혹은 선택한 블록의 소문자를 대문자로 변경
  - Ctrl + L            => 커서가 있는 라인, 혹은 선택한 블록의 라인들을 제거 (잘라내기)
  - Ctrl + C            => 블록지정을 하지 않고, 커서만 둔 상태에서 단축키를 입력하면 해당하는 줄의 코드가 복사가 된다.
  
- 코드 스니핏 (Code Snippit)
  - 작은 조각이라는 뜻이며, 개발시 여러 형태의 코드조각들을 Visual Studio가 제공해주는것을 말한다.
  - For문, Foreach문, While문, 랜덤값 생성 등등.. 이러한 기능들을 간단한 조작으로 여러 라인에 걸친 코드를 생성할 수 있다.
  - prop + tab, tab => get, set 프로퍼티 생성
  - for + tab, tab => for문 생성
  - cw + tab, tab => Console.WriteLine(); 생성

- 키보드를 이용해 스크롤을 조절하는 법
  - 컨트롤 + 상, 하 방향키

- 인텔리센스
  - Ctrl + .
  - Ctrl + Space Bar
  

- 어노테이션
  - 클래스 내부에서 컴파일러에게 코드에 대한 추가 정보를 제공한다.
  - ex) CodeFirst 에서 PK 설정을 할 프로퍼티 위에 [Key] 라고 적는다.

- XML주석 <summary>
  - XML주석에 넣은 내용은 해당 메서드나 프로퍼티에 마우스를 올려놓으면 해당 내용이 같이 출력된다.
  - 프로젝트가 커지면서 코드가 많아지면 해당 내용이 무엇인지 모르는 경우가 많기 때문에 사용한다.
  - ex) MyFunction() 메서드 위에 /// 이라고 입력하면 자동으로 <summary> 라는 주석이 생성된다.


- 직접 실행창 컬렉션 항목 100개 넘는 항목 보기
 - 컬렉션이 100개가 넘으면 직접 실행창에서 <자세히...> 라고 표시되면서 99번째 까지만 보여준다.
 - Skip 메서드를 사용해서 컬렉션.Skip(100).ToArray() 를 입력하면 100개 이후번째 항목부터 표시된다.

- 중단점
  
***
### .Net FrameWork
- 특징
  - 윈도우만 지원한다.
***
### ASP .Net Core
- 특징
  - 윈도우, 리눅스 등 여러 플랫폼 지원한다.
***
### Windows Form
- Windows Form 지역화 (Localization)
  - https://six605.tistory.com/511
- 확장 메서드

- 암호화 / 복호화

- 클래스 상속 되는것에 찾기(?)
 foreach (var t in Assembly.GetAssembly(typeof(Dock)).GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(Dock))))

