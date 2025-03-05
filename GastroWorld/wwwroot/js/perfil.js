const userData = {
    userName: "John Doe",
    userTitle: "Web Developer",
    userAbout: "Lorem ipsum dolor sit amet consectetu adipisicing elit. Fuga praesentium cupiditate hic, magnam at a.",
    profileUrl: "https://i.ibb.co/N7Kkmr1/profile.png",
    coverUrl: "https://i.ibb.co/Fmp3jvj/cover.jpg"
}
const userNameBox = document.querySelector(".user-name");
const userTitleBox = document.querySelector(".user-title");
const userAboutBox = document.querySelector(".user-about");
const coverWrapper = document.querySelector(".cover-wrapper");
const profileWrapper = document.querySelector(".avatar-wrapper");

const profileImg = document.createElement("img");
profileImg.src = userData.profileUrl;
const coverImg = document.createElement("img");
coverImg.src = userData.coverUrl

setTimeout(() => {
    insertUserDetails()
    document.querySelector(".profile-card").classList.remove("loading")
    removeSkeleton();
}, 3000);

const insertUserDetails = () => {
    userNameBox.innerHTML = userData.userName;
    userTitleBox.innerHTML = userData.userTitle;
    userAboutBox.innerHTML = userData.userAbout;
    coverWrapper.append(coverImg);
    profileWrapper.append(profileImg);
}

const removeSkeleton = () => {
    document.querySelectorAll(".skeleton").forEach((elem) => {
        elem.classList.remove("skeleton")
    })
}