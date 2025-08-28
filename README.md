# 인벤토리 UI 제작
<div align="left">
<img src="https://img.shields.io/badge/Unity-222324?style=flat&logo=unity&logoColor=white"/>
<img src="https://img.shields.io/badge/-C%23-663399?logo=Csharp&style=flat&logoColor=white"/>
</div>

---

## UI 구현 목록

### 1. UIMainMenu
<img width="509" height="284" alt="image" src="https://github.com/user-attachments/assets/5da5572d-7135-4056-a9ac-ea8d7ce2e425" /></div>

#### 화면 구성
- 캐릭터 이름 
- 레벨 / 경험치   
- 캐릭터 설명   
- 소지한 돈   
- 스탯창 ON/OFF 버튼   
- 인벤토리창 ON/OFF 버튼   

  ---
### 2. UIStatus
<img width="509" height="284" alt="image" src="https://github.com/user-attachments/assets/1cc3d8dc-c329-4e02-8dce-de5266616366" /></div>

#### 화면 구성
- 스탯창
  - 공격력(Attack) : 아이콘, 스탯 이름, 스탯 수치
  - 방어력(Defence) : 아이콘, 스탯 이름, 스탯 수치
  - 체력(Health) : 아이콘, 스탯 이름, 스탯 수치
  - 치명타(Critical) : 아이콘, 스탯 이름, 스탯 수치
    
- 뒤로가기 버튼 : 스탯창 닫기 => UIMainMenu 화면 표시

  ---
### 3. UIInventory
<img width="509" height="284" alt="image" src="https://github.com/user-attachments/assets/33f0368f-62b4-44a1-a65d-ab0ce6939d1b" /></div>

#### 화면 구성
- 인벤토리 창
  - 스크롤뷰
    - 아이템 슬롯 * 12
      - 아이템 정보(icon)
      - 장착 여부 표시(E)
      - 장착/장착 해제 버튼
        
- 뒤로가기 버튼 : 인벤토리창 닫기 => UIMainMenu 화면 표시

---

## 기능 구현 목록

### 1. 아이템 장착 / 해제 기능
![녹음 2025-08-28 125514](https://github.com/user-attachments/assets/b244a069-6750-4151-a858-eee8e3558e78)

- 아이템 슬롯에 버튼 컴포넌트 추가 : 클릭시 ON/OFF 전환
  - 장착시 "E" 표시 / 장착 해제시 "E" 사라짐

 ---
### 2. 아이템 장착/ 해제 시 추가 스탯 적용
#### 아이템 장착 전
<img width="252" height="228" alt="image" src="https://github.com/user-attachments/assets/1d21cdc9-2d82-42b4-a109-8e08fefefc6c" />
<img width="266" height="238" alt="image" src="https://github.com/user-attachments/assets/26c0f4f2-fcd5-4ba7-b1c8-4ef90e5ce969" />

#### 아이템 장착 후
<img width="255" height="232" alt="image" src="https://github.com/user-attachments/assets/ea28e7ac-17f5-4bb1-9b1f-48deb6a3e869" />
<img width="256" height="250" alt="image" src="https://github.com/user-attachments/assets/474a7e6d-e79a-4a80-9fb6-92ed8ed7c6f8" />

  ---
### 3. 인벤토리 아이템 슬롯 생성 & 무한스크롤

<img width="500" height="280" alt="carbon" src="https://github.com/user-attachments/assets/4ce8bef7-79bc-49ff-b41e-71601175f588" />
<img width="500" height="280" alt="carbon (1)" src="https://github.com/user-attachments/assets/ea68d5b9-dfe9-4e87-b5c1-b9645c4cbc6c" />

![녹음 2025-08-28 143430](https://github.com/user-attachments/assets/6dbb2574-05dd-45a7-8028-7d9bded1651f)


- 시작시 인벤토리 슬롯을 null로 12개 생성
- 인벤토리에 아이템 추가시 빈 아이템 슬롯에 아이템 정보 추가
- 아이템이 생성되어있는 아이템 슬롯 수보다 많아졌을 경우 아이템 슬롯을 추가로 생성하도록 로직 구성

---
