<template>
    <div class = "statusoftheday">
        <h1>
            Welcome user, today is day <span>{{ tweened.number.toFixed(0) }}</span> of No Nut November!
        </h1>
        <h2>How was your day?</h2>
        <div class="choises">

            <button class="successButton" @click="navigateTo('/usersStatus')">Log Success</button>
            <button class="failureButton" @click="navigateTo('/usersStatus')">Log Failure</button>
        </div>
    </div>

</template>

<style lang="css">

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
    h1 span {
  font-weight: bold;
  color: #ff0000;
  text-shadow: 0 0 5px #ff0000, 0 0 15px #ff0000, 0 0 30px #ff0000;
}
    h2 {
        font-family: 'Red Hat Display', sans-serif;
        color: #ffffff;
        margin-top: 20px;
    }

    .statusoftheday {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        height: 100vh;
    }
    .choises {
        margin-top: 20px;
        display: flex;
        gap: 20px;
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
    }

    .successButton {
        transition: background 0.3s, color 0.3s;

    }

    .successButton:hover {
        background: rgba(0, 255, 0, 0.2);
        color: #6bea51;

    }
    .failureButton {
        transition: background 0.3s, color 0.3s;
    }
    .failureButton:hover {
        background: rgba(255, 0, 0, 0.2);
        color: #ff4d4d;
    }


</style>


<script setup lang="ts">

import gsap from 'gsap'

const number = ref(77)
const tweened = reactive({
  number: 0,
})

watch(number, (n) => {
  gsap.to(
    { val: tweened.number },
    {
      duration: 2.5,
      val: Number(n) || 0,
      ease: 'cubic-bezier(.35,1.46,1,.99)',
      onUpdate() {
        tweened.number = this.targets()[0].val
      },
    }
  )
})


onMounted(() => {
  number.value = new Date().getDate()
})




</script>