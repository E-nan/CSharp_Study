# C# 정리
- c#을 공부하면서 메모해 두는 ReadMe 파일.
***
### 참고 사이트
- 강의사이트
  - https://www.inflearn.com/ => 인프런
  - https://www.udemy.com/ko/ => 유데미
  

### Convension
- 
***
### Visual Studio 2019
- 기능
  - 클래스의 Property 만들기 (getter, setter)
    - prop 입력 후 Tab 두번 입력한다.
    - propg 는 get은 되지만 private set 상태로 만들어진다.
  - 코드 좌측 몇번째 줄인지 나타내는 숫자 오른쪽에 생성되는 초록색/노란색 부분은 각각 수정된 상태, 저장된 상태를 뜻한다. 
  

- 단축키
  - Ctrl + Shift + A    => 새 항목 추가
  - Ctrl + K, Ctrl + D  => 자동 정렬
  - Ctrl + K, Ctrl + C  => 주석
  - Ctrl + K, Ctrl + U  => 해제
  
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

