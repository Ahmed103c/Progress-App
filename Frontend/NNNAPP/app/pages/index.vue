<template>
    <div class = "login-page">
        <h1>
            Welcome to the No Nut November App
        </h1>
        <input type="email" placeholder="Enter your email" />
        <button type="submit" @click="navigateTo('/statusPage')">Get Started</button>
    </div>
</template>


<style scoped>
    .login-page {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        height: 100vh;
    }
    h1 {
        font-family: 'Red Hat Display', sans-serif;
        background: rgba(255, 255, 255, 0.2);
        color: #ffffff;
        padding: 20px;
        border-radius: 10px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(0, 0, 0, 0.3);
    }
    input {
        font-family: 'Red Hat Display', sans-serif;
        margin-top: 20px;
        padding: 10px;
        font-size: 16px;
        background: rgba(255, 255, 255, 0.2);
        border-radius: 5px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        color: #ffffff;
        margin-bottom: 20px;
    }
    input::placeholder {
        color: #ffffff;
        opacity: 0.7;
    }
    button {
        font-family: 'Red Hat Display', sans-serif;
        padding: 10px 20px;
        font-size: 16px;
        background: rgba(255, 255, 255, 0.2);
        border-radius: 5px;
        box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(5px);
        -webkit-backdrop-filter: blur(5px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        color: #ffffff;
        cursor: pointer;
        transition: background 0.3s ease;
    }

</style>