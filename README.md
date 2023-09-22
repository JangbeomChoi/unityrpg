# unityrpg 
유니티 숙련주차 개인과제 입니다.
***

⚙️ 개발환경 

2022.3.8.f1

⏰ 개발일정 

2023.09.18 ~ 2023.09.22

▶️ 사용 에셋

아이템: https://assetstore.unity.com/packages/2d/gui/icons/pixel-art-icon-pack-rpg-158343

배경: https://assetstore.unity.com/packages/2d/environments/free-2d-cartoon-parallax-background-205812#content

BGM: https://assetstore.unity.com/packages/audio/music/casual-game-bgm-5-135943

🖼️ 와이어 프레임

<img width="297" alt="image" src="https://github.com/JangbeomChoi/unityrpg/assets/141592625/4aa320df-fff7-450e-911b-c9e9de405394">
<img width="367" alt="image" src="https://github.com/JangbeomChoi/unityrpg/assets/141592625/3c98ba07-49f8-49aa-9be2-46c9c7b29b90">
<img width="342" alt="image" src="https://github.com/JangbeomChoi/unityrpg/assets/141592625/6b21c6f5-29bb-4164-b513-a1994438f4e2">
<img width="196" alt="image" src="https://github.com/JangbeomChoi/unityrpg/assets/141592625/8705c38f-d34e-4fe1-8123-74f3d498e7cc">
<img width="347" alt="image" src="https://github.com/JangbeomChoi/unityrpg/assets/141592625/a42c9e98-4a5c-4a3c-91a9-08f005e91bf6">
<img width="318" alt="image" src="https://github.com/JangbeomChoi/unityrpg/assets/141592625/40dd895a-fd0b-485a-90fc-35f2fef9aadd">

## 기능
시작화면
- 시작 버튼
- 이름 받기 UI
***
메인화면
- 아이디
- 레벨
- 골드
- status버튼
- inventory 버튼
***
Status UI
- status창에 캐릭터 정보 표현
- UI 팝업시에 status,inventory버튼 사라짐
- 뒤로가기 버튼 누르면 메인화면으로 다시 이동
***
Inventory UI
- UI팝업시에 status, inventory 버튼 사라짐
- inventory창에 캐릭터 소지 물품 표현
- 아이템 장착관리
  - 장착안되있을 시 : 장착 하시겠습니까 확인 팝업
  - 장착중인 아이템 E 표시
- 뒤로가기 버튼 누르면 메인화면으로 다시 이동
***
설정 UI
- 처음화면으로 리셋버튼
- 플레이중이던 메인화면으로 리턴 버튼
- 게임 BGM 조절 슬라이더
  - 볼륨 조절 믹서 (Audio Mixer) 이용
  - 관련 스크립트 audiocontroller, audioplaymanager
  - 음소거 버튼
- 크레딧 창 버튼

## 버그 리포트
- [ ]  장비 해제할 때도 ‘장착하시겠습니까’ 출력됨
       (- 이 문제는 해결하지 못함)
- [x]  메인 화면 볼륨 슬라이더가 게임시작 화면과 동기화가 안됨
- [x]  설정창에서 게임시작으로 다시가면 볼륨 슬라이더는 리셋되지만 소리는 리셋이 안됨
- [x]  게임시작 창으로 다시 돌아갔을때 이름이 이미 저장되어있음



