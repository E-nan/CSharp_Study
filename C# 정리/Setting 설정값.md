## 프로젝트 Setting 설정값 관련 정리
별도의 DB를 사용하지 않는 프로젝트, 또는 여러 설정값이 필요한 프로젝트의 경우 
설정값을 XML 형식의 config파일을 활용한다.
<br>
프로젝트에서 Properties의 Resource를 활용하면 app.config에 기본으로 제공하는 설정외에 사용자의 추가설정이 들어가게 되고, user.config형태로 사용자 설정값이 별도로 AppData에 저장된다.
<br>
ConfigurationUserLevel이 None이면 프로그램이 실행되는 위치에 '프로젝트명.exe.config' 파일로 저장되는데 이걸 맘대로 바꾸고 싶을 경우 저장 위치와 파일명을 일일히 지정해야 하는 번거로움이 있지만 이게 필요한 경우가 있다.
<br>
열심히 만들어서 인스톨 형식으로 배포하여 Program Files 영역에 설치하게 되면 요즘 윈도우는 보안수준이 올라가서 
관리자 권한을 요구하기 때문에 Program Files 영역에 설정파일을 마음대로 썼다 지웠다 하기가 어렵다.
<br>
그래서 보통 대부분의 프로그램들은 C:\Users\유저명\AppData\Local 폴더에 설정파일들을 넣고 사용하도록 되어 있다.
<br>
* SPC의 경우 기본 Setting에서의 DbType 등 여러 설정값들이
로그인할때 DB설정에서 저장된 값을 자동으로 user.config에서 불러온다.