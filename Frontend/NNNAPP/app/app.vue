<template>
  <NuxtPage />
</template>


<style lang="css">
html, body, #__nuxt, #__layout {
  height: 100%;
  margin: 0;
  background: linear-gradient(-45deg, #0f0c29, #4e4e4e, #2a2a2a, #ffffff);
  background-size: 400% 400%;
  animation: gradientMove 15s ease infinite;
  overflow: hidden;
}

@keyframes gradientMove {
  0% { background-position: 0% 50%; }
  50% { background-position: 100% 50%; }
  100% { background-position: 0% 50%; }
}



</style>