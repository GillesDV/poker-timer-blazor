window.pokerTimer = window.pokerTimer || {};
(function () {
    const audio = new Audio('/soft-beep-sound.wav');
    audio.preload = 'auto';

    window.pokerTimer.playBeep = function () {
        try {
            audio.currentTime = 0;
            const playPromise = audio.play();
            if (playPromise && typeof playPromise.catch === 'function') {
                playPromise.catch(() => {});
            }
        } catch (e) {
            // Ignore playback errors so the timer flow is never blocked
        }
    };
})();
