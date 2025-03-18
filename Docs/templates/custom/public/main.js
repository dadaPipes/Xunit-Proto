export default {
  start: () => {
    const firstCodeWrapper = document.querySelector("article .codewrapper");

    if (firstCodeWrapper) {
      firstCodeWrapper.style.display = "none";
      console.log("First .codewrapper hidden!");
    } else {
      console.warn("No .codewrapper found!");
    }
  },
};

