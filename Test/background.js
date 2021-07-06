chrome.webRequest.onAuthRequired.addListener(function (details) {
    console.log("chrome.webRequest.onAuthRequired event has fired");
    return {
        authCredentials: { username: "admin", password: "admin" }
    };
},
    { urls: ["<all_urls>"] },
    ['blocking']);
