@import url("https://fonts.googleapis.com/css2?family=Nunito:wght@400;600;700&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;500;600;700;800&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap");
:root {
  --header-height: 3rem;
  --nav-width: 132px;
  --first-color: black;
  --first-color-light: grey;
  --white-color: #f7f6fb;
  --body-font: "Nunito", sans-serif;
  --normal-font-size: 1rem;
  --z-fixed: 100;
}

*,
::before,
::after {
  box-sizing: border-box;
}

body {
  position: relative;
  margin: var(--header-height) 0 0 0;
  font-family: var(--body-font);
  font-size: var(--normal-font-size);
  transition: 0.5s;
  background-color: rgb(20, 20, 20) !important;
}

.accordion-item {
  background-color: #161616 !important;
  border: none !important;
}

a {
  text-decoration: none;
}

.searchcontainer {
  width: 100%;
  display: flex;
  margin-left: 40px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.searchcontainer .searchicon {
  position: relative;
  left: 40px;
}
.searchcontainer .icon {
  background-color: rgb(96, 94, 0);
  backdrop-filter: blur(1px);
  opacity: 0.6;
  padding: 5px 10px 10px 10px;
  border-radius: 8px;
}
.searchcontainer .searchinputfield {
  background: #262626;
  border-radius: 8px;
  border: none;
  outline: none;
  width: 100%;
  height: 40px;
  color: white;
  padding-left: 60px;
}
.searchcontainer .secondcontainer {
  width: 260px;
  margin-left: 20px;
  height: 60px;
  cursor: pointer;
  margin-top: 2px;
  margin-right: 10px;
  align-items: center;
  position: relative;
  padding-left: 20px;
  border: 1px solid rgb(93, 93, 93);
  border-radius: 20px;
  display: flex;
}
.searchcontainer .secondcontainer .dropd {
  position: absolute;
  right: 10px;
}
.searchcontainer .secondcontainer .dropd .main {
  display: block;
  position: relative;
  cursor: pointer;
}
.searchcontainer .secondcontainer .dropd input[type=checkbox] {
  visibility: hidden;
}
.searchcontainer .secondcontainer .dropd .check {
  position: absolute;
  top: 5px;
  left: 0;
  height: 16px;
  width: 16px;
  border-radius: 5px;
  background-color: rgb(57, 56, 56);
}
.searchcontainer .secondcontainer .dropd .main input:checked ~ .check {
  background-color: #ffbb54;
}
.searchcontainer .secondcontainer .dropd .check:after {
  content: "";
  position: absolute;
  display: none;
}
.searchcontainer .secondcontainer .dropd .main input:checked ~ .check:after {
  display: block;
}
.searchcontainer .secondcontainer .dropd .main .check:after {
  left: 5px;
  top: 1px;
  width: 6px;
  height: 12px;
  border: 1px solid black;
  border-width: 0 2px 2px 0;
  -webkit-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  transform: rotate(45deg);
}
.searchcontainer .secondcontainer .lineclass {
  position: absolute;
  top: 5px;
  left: 70px;
}
.searchcontainer .secondcontainer .lineclass .userprofileheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
}
.searchcontainer .secondcontainer .lineclass .verifiedheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 11px;
  line-height: 16px;
  color: #ffffff;
  opacity: 0.4;
}
.searchcontainer .dropdown-toggle::after {
  content: none !important;
}
.searchcontainer .dropdown_submenu {
  width: 300px;
  background: #242323;
  border-radius: 16px;
  margin-top: 10px;
}
.searchcontainer .dropdown_submenu .secondcontainertwo {
  width: 260px;
  cursor: pointer;
  margin-left: 20px;
  height: 60px;
  margin-top: 2px;
  align-items: center;
  position: relative;
  border: none;
  border-radius: 20px;
  display: flex;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd {
  position: absolute;
  right: 10px;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd .main {
  display: block;
  position: relative;
  cursor: pointer;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd input[type=checkbox] {
  visibility: hidden;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd .check {
  position: absolute;
  top: 5px;
  left: 0;
  height: 16px;
  width: 16px;
  border-radius: 5px;
  background-color: rgb(57, 56, 56);
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd .main input:checked ~ .check {
  background-color: #ffbb54;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd .check:after {
  content: "";
  position: absolute;
  display: none;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd .main input:checked ~ .check:after {
  display: block;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .dropd .main .check:after {
  left: 5px;
  top: 1px;
  width: 6px;
  height: 12px;
  border: 1px solid black;
  border-width: 0 2px 2px 0;
  -webkit-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  transform: rotate(45deg);
}
.searchcontainer .dropdown_submenu .secondcontainertwo .lineclass {
  position: absolute;
  top: 5px;
  left: 50px;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .lineclass .userprofileheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 21px;
  color: #ffffff;
}
.searchcontainer .dropdown_submenu .secondcontainertwo .lineclass .verifiedheading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 11px;
  line-height: 16px;
  color: #ffffff;
  opacity: 0.4;
}
.searchcontainer .dropdown_submenu .addprofile {
  display: flex;
  width: 300px;
  align-items: center;
  justify-content: center;
  cursor: pointer;
  padding-top: 20px;
}
.searchcontainer .dropdown_submenu .addprofile .addprofiletext {
  font-weight: 400;
  font-size: 11px;
  line-height: 16px;
  color: #bdbbbb;
}

.row .search {
  width: 100%;
  height: 60px;
  background: black;
  border-radius: 14px;
  padding-left: 80px;
}
.row .searchIcon {
  position: absolute;
  left: 14.92%;
  right: 91.38%;
  top: 31.81%;
  bottom: 32.93%;
  color: #c4c4c4;
}
.row .imageDropDown {
  width: 260px;
  border: 1.5px solid #ffffff;
  border-radius: 16px;
  height: 60px;
}
.row .avatar {
  margin-top: 8px;
}
.row ::placeholder {
  color: #c4c4c4;
  text-align: left;
}

.line {
  width: 100%;
  left: 376px;
  top: 147px;
  opacity: 0.1;
  border: 1px solid #ffffff;
}

.navlist_twoclass {
  display: none;
}

.header {
  width: 100%;
  height: var(--header-height);
  position: fixed;
  top: 0;
  left: 0;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0rem 1rem;
  background-color: var(--white-color);
  z-index: var(--z-fixed);
  transition: 0.5s;
  background-color: #141414;
}

.header .openMobileMono {
  display: none;
}

.header_toggle {
  color: white;
  font-size: 1.5rem;
  z-index: 1;
  cursor: pointer;
  background-color: rgb(81, 80, 80);
  position: fixed;
  left: 50px;
  padding: 10px 6px 10px 6px;
  margin-left: 40px;
  border-radius: 0px 10px 10px 0px;
}

.header_img {
  width: 35px;
  height: 35px;
  display: flex;
  justify-content: center;
  border-radius: 50%;
  overflow: hidden;
}

.header_img img {
  width: 40px;
}

.l-navbar {
  position: fixed;
  top: 0;
  left: -30%;
  width: 90px;
  height: 100%;
  background-color: #141414;
  padding: 0.5rem 1rem 0 0;
  transition: 0.5s;
  z-index: var(--z-fixed);
}

.nav {
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  overflow: hidden;
  padding-left: 30px !important;
}

.navbar-toggler:focus {
  text-decoration: none;
  outline: 0;
  box-shadow: none !important;
}

.nav-tabs {
  border-bottom: none !important;
}

.navitemclass {
  padding-bottom: 12px;
  width: 50% !important;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: center;
}

.navitemclass:focus {
  border-bottom: 2px solid white !important;
}

.accordion-button:focus {
  z-index: 3;
  border-color: transparent !important;
  outline: 0;
  box-shadow: none !important;
}

.accordion-item:first-of-type .accordion-button {
  border-top-left-radius: 0.25rem;
  border-top-right-radius: 0.25rem;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 16px;
  margin-left: -26.5px;
  background-color: transparent !important;
  line-height: 22px;
  align-items: center;
}
.accordion-item:first-of-type .accorbd {
  background-color: #141414;
}
.accordion-item:first-of-type .accorbd .inneraccor {
  margin-left: 7px;
}
.accordion-item:first-of-type .accorbd .inneraccor span {
  font-size: 14px;
  margin-left: -20px;
}
.accordion-item:first-of-type .accorbtn {
  background-color: #141414 !important;
  border: none;
  outline: none;
  width: 280px;
  color: #ffffff;
}
.accordion-item:first-of-type .accorbtn span {
  margin-left: 38px !important;
}
.accordion-item:first-of-type .accorbtn .nav_nameTwo {
  margin-left: 40px;
}
.accordion-item:first-of-type .accorbtn:hover {
  background: radial-gradient(354.23% 3112.34% at -29.41% 333.8%, rgba(255, 187, 84, 0.2) 50.63%, rgba(255, 187, 84, 0) 100%) !important;
  color: #ffbb54 !important;
}
.accordion-item:first-of-type .accordion-button::after {
  content: "";
  background-image: url(../../img/vectorarrow.png) !important;
  margin-left: 16px;
  background-size: 11.3px;
  margin-top: -12px;
  transform: rotate(180deg);
}

.nav_list .nav-link-sub-friend {
  margin-top: 20px;
  margin-bottom: 2px;
}
.nav_list .nav-link-sub-friend span {
  margin-left: -4.2px;
}
.nav_list .nav-link-sub-vip {
  margin-top: 10px;
  margin-left: -29px;
}
.nav_list .nav-link-sub-vip span {
  margin-left: -2px;
}
.nav_list .navlinkthree {
  position: relative;
  top: 8px;
  margin-left: -28px;
  text-decoration: none;
  left: px;
}
.nav_list .nav_link {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  text-decoration: none !important;
  font-size: 16px;
  line-height: 27px;
  color: #ffffff;
}

.nav_logo,
.nav_link {
  cursor: pointer;
  display: grid;
  grid-template-columns: max-content max-content;
  align-items: center;
  text-decoration: none;
  align-items: center;
  column-gap: 2.4rem;
  padding: 0.5rem 0rem 0.5rem 1.5rem;
}

.nav_link:hover {
  background: radial-gradient(354.23% 3112.34% at -29.41% 333.8%, rgba(255, 187, 84, 0.2) 50.63%, rgba(255, 187, 84, 0) 100%) !important;
  color: #ffbb54 !important;
  height: 100% !important;
}

.nav_logo {
  margin-bottom: 2rem;
  margin-top: -10px;
  font-family: "Poppins";
  font-style: normal;
  font-size: 36px;
  text-decoration: none !important;
  line-height: 54px;
  margin-left: -45px;
  color: #ffffff;
}

.nav_logo-icon {
  font-size: 1.25rem;
  color: var(--white-color);
}

.nav_logo-name {
  color: var(--white-color);
  font-weight: 800;
  letter-spacing: 5px;
  margin-left: 13px;
}

.nav_link {
  position: relative;
  color: var(--first-color-light);
  margin-bottom: 1rem;
  left: 0;
  margin-left: -30px;
  text-decoration: none;
  transition: 0.3s;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
}

.nav_icon {
  font-size: 1.25rem;
}

.show {
  left: 0;
}

.active {
  color: var(--white-color);
}

.active::before {
  content: "";
  position: absolute;
  left: 0;
  top: 0px;
  width: 2px;
  height: 45px;
  background-color: #ffbb54;
}

.height-100 {
  height: 100vh;
}

.seperator {
  margin-top: 24px;
  opacity: 0.05;
  border: 1px solid #FFFFFF;
  margin-bottom: 28px;
}
@media screen and (max-width: 600px) {
  .seperator {
    display: none;
  }
}

.main-container-text {
  width: 100%;
  padding-left: 135px;
  padding-top: 10px;
}
.main-container-text h1 {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 38px;
  line-height: 57px;
  color: #ffffff;
  padding-left: 15px;
}
.main-container-text p {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 30px;
  color: #ffffff;
  opacity: 0.6;
  padding-left: 15px;
}

.card-container {
  display: flex;
  width: 100%;
  margin-left: -50px;
  flex-wrap: wrap;
  justify-content: space-evenly;
  align-items: flex-start;
}
.card-container .sub-card-container {
  margin-top: 20px;
  background: #0e0e0e;
  border-radius: 14px;
  width: 437px;
  height: 746px;
}
.card-container .sub-card-container .regular-text-container {
  display: flex;
  align-items: center;
  justify-content: center;
  padding-top: 30px;
}
.card-container .sub-card-container .regular-text-container button {
  width: auto;
  height: 21px;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  background: #6c532d;
  border: none;
  border-radius: 10.1667px;
  text-transform: uppercase;
  line-height: 21px;
  padding: 10px 15px 30px 15px;
  letter-spacing: 0.1em;
  color: #ffbb54;
}
.card-container .sub-card-container .basic-header-container {
  padding: 30px 0px 0px 30px;
}
.card-container .sub-card-container .basic-header-container h1 {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 38.125px;
  line-height: 57px;
  color: #ffffff;
  margin-bottom: -3px;
}
.card-container .sub-card-container .basic-header-container p {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 17.7917px;
  line-height: 27px;
  color: #ffffff;
  opacity: 0.6;
}
.card-container .sub-card-container .price-text-container {
  padding: 0px 0px 0px 30px;
  display: flex;
  align-items: center;
}
.card-container .sub-card-container .price-text-container h1 {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 42px;
  line-height: 63px;
  color: #ffffff;
  margin-bottom: 5px;
}
.card-container .sub-card-container .price-text-container p {
  padding: 12px 0px 0px 5px;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 500;
  font-size: 24px;
  line-height: 36px;
  color: #ffffff;
  opacity: 0.2;
}
.card-container .sub-card-container .subscriber-main-container {
  padding: 10px 0px 0px 30px;
}
.card-container .sub-card-container .subscriber-main-container p {
  font-family: "Coco Sharp Variable";
  font-style: normal;
  font-weight: 400;
  font-size: 17.7917px;
  line-height: 21px;
  color: #ffbb54;
}
.card-container .sub-card-container .subscribe-sub-container {
  padding: 0px 0px 0px 30px;
  margin-top: -15px;
}
.card-container .sub-card-container .subscribe-sub-container p {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 18px;
  line-height: 27px;
  color: #ffffff;
  opacity: 0.3;
}
.card-container .sub-card-container .free-trial-container {
  display: flex;
  padding: 25px 0px 20px 0px;
  align-items: center;
  justify-content: center;
}
.card-container .sub-card-container .free-trial-container button {
  position: absolute;
  width: 380px;
  border: none;
  height: 59.73px;
  background: #ffbb54;
  border-radius: 14px;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 16px;
  line-height: 24px;
  color: #08071b;
}
.card-container .sub-card-container .list-text-main-container {
  padding: 30px 0px 30px 18px;
}
.card-container .sub-card-container .list-text-main-container ul {
  display: grid;
  gap: 20px;
}
.card-container .sub-card-container .list-text-main-container ul li {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 24px;
  color: #ffbb54;
}
.card-container .sub-card-container .list-text-main-container ul li > span {
  color: white;
}

@media screen and (min-width: 768px) {
  body {
    margin: calc(var(--header-height) + 1rem) 0 0 0;
  }

  .header {
    height: calc(var(--header-height) + 1rem);
    padding: 0 2rem 0 calc(var(--nav-width) + 2rem);
  }

  .header_img {
    width: 40px;
    height: 40px;
  }
  .header_img img {
    width: 45px;
  }

  .l-navbar {
    left: 0;
    padding: 1rem 1rem 0 0;
  }

  .show {
    width: calc(var(--nav-width) + 156px);
  }
}
@media screen and (max-width: 767px) {
  .body-pd {
    padding-left: 0px;
  }
}
.test {
  padding-left: -100px;
  z-index: 1;
}

.checkToggle {
  margin-left: 235px;
  border-radius: 10px 0px 0px 10px;
  transform: rotate(180deg);
}

@media screen and (max-width: 860px) {
  .header {
    padding: 40px 20px;
  }
  .header .openMobileMono {
    display: block !important;
    position: absolute;
    right: 20px;
  }

  .l-navbar {
    display: none !important;
  }
  .l-navbar .nav {
    display: none !important;
  }

  .searchcontainer .searchicon {
    display: none;
  }
  .searchcontainer .searchinputfield {
    display: none;
  }
  .searchcontainer .icon {
    display: none;
  }
  .searchcontainer .secondcontainer {
    width: 220px !important;
    margin-left: 0px !important;
    height: 42px !important;
    padding-left: 10px !important;
    border: none !important;
    border-radius: 0px !important;
  }
  .searchcontainer .secondcontainer .dropd {
    display: none !important;
    position: absolute;
    right: 10px !important;
  }
  .searchcontainer .secondcontainer .lineclass {
    position: absolute;
    top: 2px !important;
    left: 70px;
  }
  .searchcontainer .secondcontainer .lineclass .userprofileheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 14px;
    line-height: 21px;
    color: #ffffff;
  }
  .searchcontainer .secondcontainer .lineclass .verifiedheading {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 11px;
    line-height: 16px;
    position: absolute;
    bottom: -23px;
    color: #ffffff;
    opacity: 0.4;
  }
}
.article {
  display: none;
}
@media screen and (max-width: 600px) {
  .article {
    display: block;
    color: white;
    width: 158%;
  }
}

@media screen and (max-width: 600px) {
  .bellIcon {
    display: none;
  }
}

.section2 {
  padding-left: 150px;
  padding-right: 50px;
  margin-top: 20px;
}
@media screen and (max-width: 860px) {
  .section2 {
    padding: 0px 30px !important;
    margin-left: 0px;
  }
}
@media screen and (max-width: 767px) {
  .section2 {
    margin: 10px !important;
    padding: 10px !important;
  }
}
.section2 .mobileimage {
  display: none;
}
.section2 .mobileimage img {
  width: 35rem;
}
@media screen and (max-width: 600px) {
  .section2 .mobileimage {
    display: flex;
    justify-content: center;
  }
}
.section2 .rectangle {
  margin-top: 37px;
  border-radius: 14px;
  width: 100%;
}
@media screen and (max-width: 600px) {
  .section2 .rectangle {
    display: none;
  }
}
@media screen and (max-width: 600px) {
  .section2 .newDisplay {
    display: flex;
    margin-top: -60px;
    flex-direction: column-reverse;
  }
}
.section2 .newDisplay .paragraph1 {
  margin-top: 34px;
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 30px;
  color: #ffffff;
  opacity: 0.6;
}
@media screen and (max-width: 600px) {
  .section2 .newDisplay .paragraph1 {
    margin-top: -13px;
    line-height: 20px;
  }
}
.section2 .newDisplay .paragraph2 {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 600;
  font-size: 30px;
  line-height: 45px;
  color: #ffffff;
}
@media screen and (max-width: 600px) {
  .section2 .newDisplay .paragraph2 {
    font-size: 24px;
    padding-right: 72px;
  }
}
@media screen and (max-width: 420px) {
  .section2 .newDisplay .paragraph2 {
    line-height: 28px;
  }
}
.section2 .newDisplay .heading {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 16px;
  line-height: 24px;
  color: #ffffff;
  opacity: 0.3;
}
@media screen and (max-width: 600px) {
  .section2 .newDisplay .heading {
    margin-top: 75px;
  }
}
.section2 .newDisplay {
  display: flex;
  flex-direction: column;
}
@media screen and (max-width: 600px) {
  .section2 .newDisplay {
    display: flex;
    flex-direction: column-reverse;
  }
}
.section2 .p3 {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 400;
  font-size: 17px;
  line-height: 37px;
  /* or 218% */
  padding-right: 50px;
  letter-spacing: 0.02em;
  color: #7f7f7f;
}
@media screen and (max-width: 600px) {
  .section2 .p3 {
    font-size: 12px;
    font-weight: 300;
    line-height: 20px;
    padding-right: 0px;
    word-spacing: 0.25px;
    margin-top: 10px;
  }
}

@media screen and (max-width: 991px) {
  .section2 {
    padding-left: 20px;
    padding-right: 20px;
    margin-top: 10px;
  }

  .transactionContent {
    padding-left: 40px;
    margin-top: -50px !important;
  }

  .formcontentDiv {
    padding: 20px 20px 20px 20px;
  }

  .newcontainer {
    display: none !important;
  }

  .maincontainer {
    margin-left: -20px;
    padding-left: 0px;
    margin-top: -10px;
  }

  .topdiv {
    position: relative;
    top: -10px;
    padding-left: 20px;
  }

  .navlist_twoclass {
    display: block !important;
    padding-left: 80px;
    padding-top: 40px;
  }
  .navlist_twoclass a {
    text-decoration: none !important;
  }

  .header {
    padding: 40px 20px;
  }

  .header .openMobileMono {
    display: block !important;
    position: absolute;
    right: 20px;
  }

  .header_toggle {
    display: none;
  }

  .l-navbar {
    display: none !important;
  }

  .l-navbar .nav {
    display: none !important;
  }

  .searchcontainer .bellIcon {
    display: none;
  }

  .searchcontainer .searchicon {
    display: none;
  }

  .searchcontainer .secondcontainer {
    display: none !important;
  }

  .searchcontainer .searchinputfield {
    display: none;
  }

  .searchcontainer .icon {
    display: none;
  }

  .main-container-text {
    width: 100%;
    padding-left: 0px;
    padding-top: 20px;
  }
  .main-container-text h1 {
    padding-left: 20px;
    font-weight: 600;
    font-size: 26px;
    line-height: 39px;
  }
  .main-container-text p {
    padding-left: 20px;
    font-weight: 400;
    font-size: 14px;
    line-height: 26px;
  }

  .card-container {
    display: flex;
    width: 100%;
    margin-left: 0px;
    flex-wrap: wrap;
    justify-content: center;
    align-items: center;
  }
  .card-container .sub-card-container {
    width: 350px;
    height: auto;
    border-radius: 35px;
  }
  .card-container .sub-card-container .regular-text-container {
    display: flex;
    align-items: center;
    justify-content: center;
    padding-top: 30px;
  }
  .card-container .sub-card-container .regular-text-container button {
    width: auto;
    height: 21px;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    background: #6c532d;
    border: none;
    border-radius: 10.1667px;
    text-transform: uppercase;
    line-height: 21px;
    padding: 10px 15px 30px 15px;
    letter-spacing: 0.1em;
    color: #ffbb54;
  }
  .card-container .sub-card-container .basic-header-container {
    padding: 30px 0px 0px 5px;
  }
  .card-container .sub-card-container .basic-header-container h1 {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 38.125px;
    line-height: 57px;
    color: #ffffff;
  }
  .card-container .sub-card-container .basic-header-container p {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 400;
    font-size: 17.7917px;
    line-height: 27px;
    color: #ffffff;
    opacity: 0.6;
  }
  .card-container .sub-card-container .price-text-container {
    padding: 10px 0px 0px 5px;
    display: flex;
    align-items: center;
  }
  .card-container .sub-card-container .price-text-container h1 {
    font-family: "Poppins";
    font-style: normal;
    font-weight: 600;
    font-size: 42px;
    line-height: 63px;
    color: #ffffff;
  }
  .card-container .sub-card-container .price-text-container p {
    padding: 12px 0px 0px 5px;
    font-family: "Poppins";
    font-style: normal;
    font-weight: 500;
    font-size: 24px;
    line-height: 36px;
    color: #ffffff;
    opacity: 0.2;
  }
  .card-container .sub-card-container .subscriber-main-container {
    display: none;
  }
  .card-container .sub-card-container .subscribe-sub-container {
    display: none;
  }
  .card-container .sub-card-container .free-trial-container button {
    width: 299px;
    height: 42px;
    font-weight: 600;
    font-size: 14px;
    line-height: 21px;
  }
  .card-container .sub-card-container .list-text-main-container {
    padding: 30px 0px 30px 10px;
  }
  .card-container .sub-card-container .list-text-main-container ul {
    display: grid;
    gap: 10px;
  }
  .card-container .sub-card-container .list-text-main-container ul li {
    font-weight: 400;
    font-size: 10.1113px;
    line-height: 15px;
  }
}
@media screen and (max-width: 420px) {
  .navbar-toggler {
    position: fixed !important;
    right: 5px !important;
    top: 5px !important;
    z-index: 1;
  }
}

/*# sourceMappingURL=style.cs.map */
